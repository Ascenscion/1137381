using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8v2
{
    public partial class Form1 : Form
    {
        double resultadoValor = 0;
        string operacionHecha = "";
        bool isOperacionHecha = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
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
            } else
            {
                displayOperaciones.Text += boton.Text;
            }
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacionHecha = boton.Text;
            resultadoValor = Double.Parse(displayOperaciones.Text);
            opActual.Text = resultadoValor + " " + operacionHecha;
            isOperacionHecha = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayOperaciones.Text = "0";
            opActual.Text = "0";
            resultadoValor = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (displayOperaciones.TextLength > 0)
            displayOperaciones.Text = displayOperaciones.Text.Substring(0, displayOperaciones.TextLength - 1); 

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operacionHecha == "+")
            {
                displayOperaciones.Text = (resultadoValor + double.Parse(displayOperaciones.Text)).ToString();
            }
            else if (operacionHecha == "-")
            {
                displayOperaciones.Text = (resultadoValor - double.Parse(displayOperaciones.Text)).ToString();
            }
            else if (operacionHecha == "*")
            {
                displayOperaciones.Text = (resultadoValor * double.Parse(displayOperaciones.Text)).ToString();
            }
            else if(operacionHecha == "/")
            {
                displayOperaciones.Text = (resultadoValor / double.Parse(displayOperaciones.Text)).ToString();
            }
        }
      

        private void angulos_click(object sender, EventArgs e)
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
            } else if (operacionHecha == "sen")
            {
                displayOperaciones.Text = Math.Sin(resultadoValor).ToString();
            } else if(operacionHecha == "tan")
            {
                displayOperaciones.Text = Math.Tan(resultadoValor).ToString();
            }
        }
    }
}
