using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestoreDeInventarios
{
    public partial class Agregar : Form
    {
        private Socket clientSocket;
        private int opcion = 3;

        public Agregar(Socket socket)
        {
            InitializeComponent();
            clientSocket = socket;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            Application.Exit();
        }

        private void btnAgr_Click(object sender, EventArgs e)
        {
            try
            {
                string opcionData = opcion.ToString();
                byte[] opcionBytes = Encoding.UTF8.GetBytes(opcionData);
                clientSocket.Send(opcionBytes);

                Producto productoNuevo = new Producto(txtCod.Text, txtMar.Text, txtNom.Text, Convert.ToInt32(txtCan.Text), Convert.ToDouble(txtPre.Text));
                string productoJson = JsonConvert.SerializeObject(productoNuevo);
                byte[] buff = Encoding.UTF8.GetBytes(productoJson);
                clientSocket.Send(buff);
                MessageBox.Show("Se agrego exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
            PanelDeControl v2 = new PanelDeControl(clientSocket);
            this.Hide();
            v2.Show();
        }

        private void btnAgr_Click_1(object sender, EventArgs e)
        {
            try
            {
                string opcionData = opcion.ToString();
                byte[] opcionBytes = Encoding.UTF8.GetBytes(opcionData);
                clientSocket.Send(opcionBytes);

                Producto productoNuevo = new Producto(txtCod.Text, txtMar.Text, txtNom.Text, Convert.ToInt32(txtCan.Text), Convert.ToDouble(txtPre.Text));
                string productoJson = JsonConvert.SerializeObject(productoNuevo);
                byte[] buff = Encoding.UTF8.GetBytes(productoJson);
                clientSocket.Send(buff);
                MessageBox.Show("Se agrego exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            PanelDeControl v2 = new PanelDeControl(clientSocket);
            this.Hide();
            v2.Show();
        }
    }
}
