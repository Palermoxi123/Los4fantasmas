using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestoreDeInventarios
{
    public class Producto
    {
        public string codigo;
        public string marca;
        public string nombre;
        public int cantidad;
        public double precio;

        public Producto(string codigo, string marca, string nombre, int cantidad, double precio)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}
