using System.Net;
using System.Net.Sockets;
using System.Text;

namespace gestoreDeInventarios
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;
        private const string serverIP = "127.0.0.1";
        private const int serverPort = 1234;
        private const int opcion = 1;

        public Form1()
        {
            InitializeComponent();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            clientSocket.Connect(serverEndPoint);
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(user.Text) || string.IsNullOrWhiteSpace(contra.Text))
            {
                lbl.Text = "Por favor, ingresa usuario y contraseña.";
                return;
            }

            try
            {
                string opcionData = opcion.ToString();
                byte[] opcionBytes = Encoding.UTF8.GetBytes(opcionData);

                clientSocket.Send(opcionBytes);
                Console.WriteLine("Opción enviada al servidor");

                string datosEnviar = user.Text + "," + contra.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(datosEnviar);

                clientSocket.Send(buffer);
                Console.WriteLine("Datos enviados al servidor");

                byte[] buffe = new byte[1024];
                int bytesRead = clientSocket.Receive(buffe);
                string datosRecibidos = Encoding.UTF8.GetString(buffe, 0, bytesRead);

                if (datosRecibidos == "exito")
                {
                    PanelDeControl v2 = new PanelDeControl(clientSocket);
                    this.Hide();
                    v2.Show();
                }
                else
                {
                    lbl.Text = datosRecibidos;
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Error: " + ex.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }
    }
}
