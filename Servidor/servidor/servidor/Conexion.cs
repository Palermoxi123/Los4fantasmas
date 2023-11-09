using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace servidor
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "mydb";
        static string usuario = "root";
        static string contraseña = "admin";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd;

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                Console.WriteLine("Hola Mundo");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }

            return conexion;
        }

        public void cerrar()
        {
            conexion.Close();
        }

        public string inicioSesion(string user, string contra, Conexion x)
        {
            string mensaje = "";
            try
            {
                string query = "SELECT contraseña FROM mydb.usuario WHERE nombre = @nombre";
                using (MySqlConnection connection = x.establecerConexion())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", user);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string contraseñaBD = Convert.ToString(result);

                            if (contraseñaBD == contra)
                            {
                                mensaje = "exito";
                            }
                            else
                            {
                                mensaje = "la contraseña es incorrecta";
                            }
                        }
                        else
                        {
                            mensaje = "no se encontro el usuario";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en inicioSesion: " + ex.Message);
            }
            x.cerrar();
            return mensaje;
        }

        public List<Producto> productos(Conexion x)
        {
            List<Producto> productos = new List<Producto>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader = null;

            try
            {
                string query = "SELECT codigo, marca, nombre, cantidad, precio FROM productos";
                cmd.Connection = x.establecerConexion();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto(reader.GetString("codigo"), reader.GetString("marca"), reader.GetString("nombre"), reader.GetInt32("cantidad"), reader.GetDouble("precio"));
                    productos.Add(producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                x.cerrar();
                cmd.Dispose();
            }
            return productos;
        }

        public void insertarProducto(Producto producto, Conexion x)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                
                string query = "INSERT INTO productos (codigo, marca, nombre, cantidad, precio) VALUES (@codigo, @marca, @nombre, @cantidad, @precio)";
                cmd.Connection = x.establecerConexion();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@codigo", producto.codigo);
                cmd.Parameters.AddWithValue("@marca", producto.marca);
                cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                cmd.Parameters.AddWithValue("@precio", producto.precio);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine( ex.Message);
            }
            finally
            {
                x.cerrar();
                cmd.Dispose();
            }
        }

        public void eliminarProducto(Conexion x, string codigo)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {

                string query = "DELETE FROM productos WHERE codigo = @codigo";
                cmd.Connection = x.establecerConexion();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine( ex.Message);
            }
            finally
            {
                x.cerrar();
                cmd.Dispose();
            }
        }

        public void editarProducto(Conexion x, Producto producto, Producto productoModificado) 
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {

                string query = "UPDATE productos SET codigo = @NuevoCodigo, marca = @NuevaMarca, nombre = @NuevoNombre, cantidad = @NuevaCantidad, precio = @NuevoPrecio WHERE codigo = @codigo ";
                cmd.Connection = x.establecerConexion();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@NuevoCodigo", productoModificado.codigo);
                cmd.Parameters.AddWithValue("@NuevaMarca", productoModificado.marca);
                cmd.Parameters.AddWithValue("@NuevoNombre", productoModificado.nombre);
                cmd.Parameters.AddWithValue("@NuevaCantidad", productoModificado.cantidad);
                cmd.Parameters.AddWithValue("@NuevoPrecio", productoModificado.precio);
                cmd.Parameters.AddWithValue("@codigo", producto.codigo);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                x.cerrar();
                cmd.Dispose();
            }
        }

    }
}
