using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gestoreDeInventarios
{
    public partial class PanelDeControl : Form
    {
        private Socket clientSocket;
        private int opcion = 2;
        private List<Producto> productos = new List<Producto>();
        private Thread dataThread;
        private bool detenerHilo = false;


        public PanelDeControl(Socket socket)
        {
            InitializeComponent();
            clientSocket = socket;
            opcion = 2;
            // Crear e iniciar el hilo de comunicación en el constructor
            dataThread = new Thread(CargarDatosThread);
            dataThread.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            detenerHilo = true;
            Agregar v3 = new Agregar(clientSocket);
            v3.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            detenerHilo = true;
            opcion = 4;
            enviarOpcionAlServidor();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codigo = Convert.ToString(selectedRow.Cells["Column1"].Value);
                string marca = Convert.ToString(selectedRow.Cells["Column2"].Value);
                string nombre = Convert.ToString(selectedRow.Cells["Column3"].Value);
                int cantidad = Convert.ToInt32(selectedRow.Cells["Column4"].Value);
                double precio = Convert.ToDouble(selectedRow.Cells["Column5"].Value);

                Producto producto = new Producto(codigo,marca,nombre,cantidad,precio);

                string productoJson = JsonConvert.SerializeObject(producto);
                byte[] buff = Encoding.UTF8.GetBytes(productoJson);
                clientSocket.Send(buff);

                dataGridView1.Rows.Remove(selectedRow);
                MessageBox.Show("Se elimino exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
            detenerHilo = false;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            detenerHilo = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codigo = Convert.ToString(selectedRow.Cells["Column1"].Value);
                string marca = Convert.ToString(selectedRow.Cells["Column2"].Value);
                string nombre = Convert.ToString(selectedRow.Cells["Column3"].Value);
                int cantidad = Convert.ToInt32(selectedRow.Cells["Column4"].Value);
                double precio = Convert.ToDouble(selectedRow.Cells["Column5"].Value);

                Producto producto = new Producto(codigo, marca, nombre, cantidad, precio);
                Modificar v4 = new Modificar(clientSocket, producto);
                v4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
            }
            
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {

        }

        private void enviarOpcionAlServidor()
        {
            try
            {
                string opcionData = opcion.ToString();
                byte[] opcionBytes = Encoding.UTF8.GetBytes(opcionData);

                clientSocket.Send(opcionBytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cargarDatosEnFilas()
        {
            dataGridView1.Rows.Clear();
            foreach (Producto producto in productos)
            {
                dataGridView1.Rows.Add(producto.codigo, producto.marca, producto.nombre, producto.cantidad, producto.precio);
            }
        }

        private void recibirDatosYMostrar()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead = clientSocket.Receive(buffer);

                if (bytesRead > 0)
                {
                    string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    productos = JsonConvert.DeserializeObject<List<Producto>>(json);
                    dataGridView1.Invoke(new Action(() => cargarDatosEnFilas()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CargarDatosThread()
        {
            while (!detenerHilo)
            {
                try
                {
                    opcion = 2;
                    enviarOpcionAlServidor();
                    recibirDatosYMostrar();
                    Thread.Sleep(6000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            detenerHilo = true;
            clientSocket.Close();
            Application.Exit();
        }

        private void btnAg_Click_1(object sender, EventArgs e)
        {
            detenerHilo = true;
            Agregar v3 = new Agregar(clientSocket);
            v3.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            detenerHilo = true;
            clientSocket.Close();
            Application.Exit();
        }

        private void btnMod_Click_1(object sender, EventArgs e)
        {
            detenerHilo = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codigo = Convert.ToString(selectedRow.Cells["Column1"].Value);
                string marca = Convert.ToString(selectedRow.Cells["Column2"].Value);
                string nombre = Convert.ToString(selectedRow.Cells["Column3"].Value);
                int cantidad = Convert.ToInt32(selectedRow.Cells["Column4"].Value);
                double precio = Convert.ToDouble(selectedRow.Cells["Column5"].Value);

                Producto producto = new Producto(codigo, marca, nombre, cantidad, precio);
                Modificar v4 = new Modificar(clientSocket, producto);
                v4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            detenerHilo = true;
            opcion = 4;
            enviarOpcionAlServidor();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string codigo = Convert.ToString(selectedRow.Cells["Column1"].Value);
                string marca = Convert.ToString(selectedRow.Cells["Column2"].Value);
                string nombre = Convert.ToString(selectedRow.Cells["Column3"].Value);
                int cantidad = Convert.ToInt32(selectedRow.Cells["Column4"].Value);
                double precio = Convert.ToDouble(selectedRow.Cells["Column5"].Value);

                Producto producto = new Producto(codigo, marca, nombre, cantidad, precio);

                string productoJson = JsonConvert.SerializeObject(producto);
                byte[] buff = Encoding.UTF8.GetBytes(productoJson);
                clientSocket.Send(buff);

                dataGridView1.Rows.Remove(selectedRow);
                MessageBox.Show("Se elimino exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
            detenerHilo = false;
        }
    }
}
