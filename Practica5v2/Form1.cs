using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = textBox1.Text;
            textBox2.Text = (cadena.Length).ToString();
            textBox3.Text = cadena[cadena.Length - 1].ToString();
            textBox4.Text = cadena[0].ToString();
            if (cadena.Length >= 6)
            {
                string sub = cadena.Substring(2, 6);
                textBox5.Text = sub;
            }
            else if (cadena.Length < 6)
            {
                string sub = cadena.Substring(2, cadena.Length - 1);
                textBox5.Text = sub;

            }

            int indice = cadena.IndexOf('a');
            if (indice != -1)
                textBox6.Text = (indice + 1).ToString();
            else
                textBox6.Text = "No contiene letra A";

            textBox7.Text = cadena.ToUpper();
            textBox8.Text = cadena.ToLower();
            textBox9.Text = cadena.Replace(" ", "");
        }
    }
}
