using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11
{
    public partial class Form1 : Form
    {
        double resultadoValor = 0;
        string operacionHecha = "";
        bool isOperacionHecha = false;
        string operacionActual = "";
        public Form1()
        {
            InitializeComponent();
            CrearArchivo("historial.txt", "");
        }

        private void bNumeros_click(object sender, EventArgs e)
        {
            if (displayOperaciones.Text == "0" || isOperacionHecha)
                displayOperaciones.Clear();

            isOperacionHecha = false;
            Button boton = (Button)sender;

            //Validar decimales sea mayor a 1
            if (boton.Text == ".")
            {
                if (!displayOperaciones.Text.Contains("."))
                    displayOperaciones.Text += boton.Text;
                operacionActual += boton.Text;
            }
            else
            {
                displayOperaciones.Text += boton.Text;
                operacionActual += boton.Text;
            }
        }

        private void bOperador_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacionHecha = boton.Text;
            resultadoValor = Double.Parse(displayOperaciones.Text);
            opActual.Text = resultadoValor + " " + operacionHecha;
            operacionActual += boton.Text;
            isOperacionHecha = true;
        }

        private void bCE_click_Click(object sender, EventArgs e)
        {
            displayOperaciones.Text = "";
            opActual.Text = "";
            resultadoValor = 0;
            operacionActual = "";
        }

        private void bC_Click_Click(object sender, EventArgs e)
        {
            if (displayOperaciones.TextLength > 0)
            {
                displayOperaciones.Text = displayOperaciones.Text.Substring(0, displayOperaciones.TextLength - 1);
                if(operacionActual.Length > 1)
                operacionActual = operacionActual.Substring(0, operacionActual.Length - 1);
                else
                    operacionActual = "0";
            }
                
        }

        private void bIgual_Click_Click(object sender, EventArgs e)
        {
            Button boton = (Button )sender;
            operacionActual += boton.Text;
            if (operacionHecha == "+")
            {
                displayOperaciones.Text = (resultadoValor + double.Parse(displayOperaciones.Text)).ToString();
                operacionActual += displayOperaciones.Text;
            }
            else if (operacionHecha == "-")
            {
                displayOperaciones.Text = (resultadoValor - double.Parse(displayOperaciones.Text)).ToString();
                operacionActual += displayOperaciones.Text;
            }
            else if (operacionHecha == "*")
            {
                displayOperaciones.Text = (resultadoValor * double.Parse(displayOperaciones.Text)).ToString();
                operacionActual += displayOperaciones.Text;
            }
            else if (operacionHecha == "/")
            {
                displayOperaciones.Text = (resultadoValor / double.Parse(displayOperaciones.Text)).ToString();
                operacionActual += displayOperaciones.Text;
            }

            richTextBox1.Text += "\n" + operacionActual;
            operacionActual = "\n" + displayOperaciones.Text;

        }

        private void bAngulos_click(object sender, EventArgs e)
        {
            if (isOperacionHecha)
                displayOperaciones.Clear();

            isOperacionHecha = true;
            Button boton = (Button)sender;
            operacionHecha = boton.Text;
            resultadoValor = Double.Parse(displayOperaciones.Text);
            if (operacionHecha == "cos")
            {
                displayOperaciones.Text = Math.Cos(resultadoValor).ToString();
                operacionActual += " = " + boton.Text;
                operacionActual += displayOperaciones.Text.ToString();
                richTextBox1.Text += " " + operacionActual + '\n';
            }
            else if (operacionHecha == "sen")
            {
                displayOperaciones.Text = Math.Sin(resultadoValor).ToString();
                operacionActual += " = " + boton.Text;
                operacionActual += displayOperaciones.Text.ToString();
                richTextBox1.Text += " " + operacionActual + '\n';
            }
            else if (operacionHecha == "tan")
            {
                displayOperaciones.Text = Math.Tan(resultadoValor).ToString();
                operacionActual += " = " + boton.Text;
                operacionActual += displayOperaciones.Text.ToString();
                richTextBox1.Text += " " + operacionActual + '\n';
            }
            operacionActual = "";
        }

        public static void CrearArchivo(string rutaArchivo, string contenidoTexto)
        {
            if (!File.Exists(rutaArchivo))
            {
                using (StreamWriter archivo = File.CreateText(rutaArchivo))
                {
                    archivo.WriteLine(contenidoTexto);
                }
            } 
        }

        public static void AgregarContenido(string rutaArchivo, string contenidoTexto)
        {
            using (StreamWriter archivo = File.AppendText(rutaArchivo))
            {
                archivo.WriteLine(contenidoTexto);
            }
        }

        public static string LeerArchivo(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader archivo = File.OpenText(rutaArchivo))
                {
                    string contenido = archivo.ReadToEnd();
                    return contenido;
                }
            }
            else
            {
                return "El archivo no existe";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void guardarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarContenido("historial.txt", richTextBox1.Text);
        }

        private void verHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = LeerArchivo("historial.txt").Trim();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
