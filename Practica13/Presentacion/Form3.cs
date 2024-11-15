using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form3 : Form
    {
        ProductoService productoService = new ProductoService();
        string nombre;
        string descripcion;
        string marca;
        double precio;
        int stock;
        int id;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox2.Text;
            descripcion = textBox3.Text;
            marca = textBox4.Text;
            precio = double.Parse(textBox5.Text);
            stock = int.Parse(textBox6.Text);
            id = int.Parse(textBox1.Text);
            productoService.EditarProducto(nombre, descripcion, marca, precio, stock, id);
            CargarProductos();
        }

        private void CargarProductos()
        {
            DataTable productos = productoService.ObtenerProductos();
        }
    }
}
