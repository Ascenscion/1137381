using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        private FontStyle estilo = FontStyle.Regular;
        private string tipo = "Arial";
        private float tamanio = 8f;
       
        public Form1()
        {
            InitializeComponent();
        }

        private Font crearFuente()
        {
            Font fuente;
            return fuente = new Font(tipo, tamanio, estilo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                estilo = FontStyle.Bold;
                label1.Font = crearFuente();
            } else
            {
                estilo = FontStyle.Regular;
                label1.Font = crearFuente();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                estilo = FontStyle.Italic;
                label1.Font = crearFuente();
            } else
            {
                estilo = FontStyle.Regular;
                label1.Font = crearFuente();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                estilo = FontStyle.Strikeout;
                label1.Font = crearFuente();
            }
            else
            {
                estilo = FontStyle.Regular;
                label1.Font = crearFuente();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                estilo = FontStyle.Underline;
                label1.Font = crearFuente();
            }
            else
            {
                estilo = FontStyle.Regular;
                label1.Font = crearFuente();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                tipo = "Consolas";
                label1.Font = crearFuente();
            }
            else
            {
                tipo = "Arial";
                label1.Font = crearFuente();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                tipo = "Collona MT";
                label1.Font = crearFuente();
            }
            else
            {
                tipo = "Arial";
                label1.Font = crearFuente();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                tipo = "Verdana";
                label1.Font = crearFuente();
            }
            else
            {
                tipo = "Arial";
                label1.Font = crearFuente();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                tipo = "Broadway";
                label1.Font = crearFuente();
            }
            else
            {
                tipo = "Arial";
                label1.Font = crearFuente();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                tamanio = 8f;
                label1.Font = crearFuente();
            } else
            {
                tamanio = 8f;
                label1.Font = crearFuente();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                tamanio = 12f;
                label1.Font = crearFuente();
            }
            else
            {
                tamanio = 8f;
                label1.Font = crearFuente();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                tamanio = 16f;
                label1.Font = crearFuente();
            }
            else
            {
                tamanio = 8f;
                label1.Font = crearFuente();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                tamanio = 20f;
                label1.Font = crearFuente();
            }
            else
            {
                tamanio = 8f;
                label1.Font = crearFuente();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estilo = FontStyle.Regular;
            tipo = "Arial";
            tamanio = 8f;
            label1.Font = crearFuente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
