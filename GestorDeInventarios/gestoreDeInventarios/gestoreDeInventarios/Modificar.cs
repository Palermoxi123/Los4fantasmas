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
    public partial class Modificar : Form
    {
        private Socket clientSocket;
        private Producto producto;
        private int opcion = 5;
        public Modificar(Socket socket, Producto productoBase)
        {
            InitializeComponent();
            clientSocket = socket;
            producto = productoBase;
            lblCod.Text = producto.codigo;
            lblMar.Text = producto.marca;
            lblNom.Text = producto.nombre;
            lblCan.Text = Convert.ToString(producto.cantidad);
            lblPre.Text = Convert.ToString(producto.precio);
            txtCod.Text = producto.codigo;
            txtMar.Text = producto.marca;
            txtNom.Text = producto.nombre;
            txtCan.Text = Convert.ToString(producto.cantidad);
            txtPre.Text = Convert.ToString(producto.precio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcionData = opcion.ToString();
            byte[] opcionBytes = Encoding.UTF8.GetBytes(opcionData);
            clientSocket.Send(opcionBytes);

            string productojs = JsonConvert.SerializeObject(producto);
            byte[] buffe = Encoding.UTF8.GetBytes(productojs);
            clientSocket.Send(buffe);

            Producto productoModificado = new Producto(txtCod.Text, txtMar.Text, txtNom.Text, Convert.ToInt32(txtCan.Text), Convert.ToDouble(txtPre.Text));
            string productoJson = JsonConvert.SerializeObject(productoModificado);
            byte[] buff = Encoding.UTF8.GetBytes(productoJson);
            clientSocket.Send(buff);
            MessageBox.Show("Se modifico exitosamente");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            PanelDeControl v2 = new PanelDeControl(clientSocket);
            v2.Show();
            this.Hide();
            
        }
    }
}
