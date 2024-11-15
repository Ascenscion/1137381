using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Producto
    {
        private static int contadorID = 0;
        private string nombre;
        private string descripcion;
        private string marca;
        private double precio;
        private int inventario;
        private int id;

        public Producto(string nombre, string descripcion, string marca, double precio, int inventario)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.precio = precio;
            this.inventario = inventario;
            this.id = ++ contadorID;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Marca { get { return marca; } set { marca = value; } }     
        public double Precio { get { return precio; } set { precio = value; } }
        public int Inventario { get { return inventario; } set { inventario = value; } }
        public int ID { get { return id; } }
    }
}
