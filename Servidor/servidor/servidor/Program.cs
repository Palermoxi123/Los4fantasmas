using servidor;
using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

class Program
{
    static int maxClients = 4;
    static int connectedClientsCount = 0;

    static void Main(string[] args)
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 1234);
        serverSocket.Bind(serverEndPoint);
        serverSocket.Listen(maxClients);

        Console.WriteLine("Servidor escuchando en " + serverEndPoint);

        while (connectedClientsCount < maxClients)
        {
            Socket clientSocket = serverSocket.Accept();
            Console.WriteLine("Cliente conectado desde: " + clientSocket.RemoteEndPoint);
            Thread clientThread = new Thread(() =>
            {
                comunicar(clientSocket);
            });
            clientThread.Start();
        }
        connectedClientsCount++;
    }

    static void comunicar(Socket clientSocket)
    {
        byte[] buffer = new byte[1024];
        int bytesRead;
        Conexion conexion = new Conexion();

        try
        {
            while (true)
            {
                bytesRead = clientSocket.Receive(buffer);
                if (bytesRead == 0)
                {
                    break;
                }
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                int opcion = Convert.ToInt32(dataReceived);

                switch (opcion)
                {
                    case 1:
                        bytesRead = clientSocket.Receive(buffer);
                        dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        string[] parameters = dataReceived.Split(',');

                        if (parameters.Length >= 2)
                        {
                            string usuario = parameters[0];
                            string contrasena = parameters[1];
                            string resultado = conexion.inicioSesion(usuario, contrasena, conexion);

                            if (resultado == "exito")
                            {
                                Console.WriteLine(resultado);
                            }
                            else if (resultado == "la contraseña es incorrecta")
                            {
                                Console.WriteLine(resultado);
                            }
                            else
                            {
                                Console.WriteLine(resultado);
                            }
                            byte[] bufferResponse = Encoding.UTF8.GetBytes(resultado);
                            clientSocket.Send(bufferResponse);
                        }
                        break;

                    case 2:
                        List<Producto> productos = conexion.productos(conexion);
                        byte[] buff = Encoding.UTF8.GetBytes(serializarProductos(productos));
                        clientSocket.Send(buff);
                        break;
                    case 3:
                        bytesRead = clientSocket.Receive(buffer);
                        string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Producto productoNuevo = JsonConvert.DeserializeObject<Producto>(json);
                        conexion.insertarProducto(productoNuevo, conexion);
                        break;
                    case 4:
                        bytesRead = clientSocket.Receive(buffer);
                        string deleted = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Producto productoEliminado = JsonConvert.DeserializeObject<Producto>(deleted);
                        conexion.eliminarProducto(conexion, productoEliminado.codigo);
                        break;
                    case 5:
                        bytesRead = clientSocket.Receive(buffer);
                        string productoBase = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Producto productoB = JsonConvert.DeserializeObject<Producto>(productoBase);
                        bytesRead = clientSocket.Receive(buffer);
                        string productoModificado = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Producto productoM = JsonConvert.DeserializeObject<Producto>(productoModificado);
                        conexion.editarProducto(conexion,productoB,productoM);
                        break;
                    default:
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            clientSocket.Close();
            Console.WriteLine("Cliente desconectado.");
            connectedClientsCount--;
        }
    }

    static string serializarProductos(List<Producto> productos)
    {
        string productosJson = JsonConvert.SerializeObject(productos);
        return productosJson;
    }
}
