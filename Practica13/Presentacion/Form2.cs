using Negocios;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductoService = Negocios.ProductoService;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        private ProductoService productoService = new Negocios.ProductoService();
        string nombre;
        string descripcion;
        string marca;
        double precio;
        int stock;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            descripcion = textBox2.Text;
            marca = textBox3.Text;
            precio = double.Parse(textBox4.Text);
            stock = int.Parse(textBox5.Text);

            Producto producto = new Producto(nombre, descripcion, marca, precio, stock); 

            productoService.InsertarProducto(nombre,descripcion,marca,precio,stock);
            ClearRows();

            MessageBox.Show("Producto guardado con exito.");
        }

        private void CargarProductos()
        {
            DataTable productos = productoService.ObtenerProductos();
            dataGridView1.DataSource = productos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void ClearRows()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
