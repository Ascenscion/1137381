using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        bool siOperador = false;
        string expressionTemp = "";
        bool completo = false;
        double num1;
        double num2;
        char[] operador = { '+', '-', '*', '/' };


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double resultado(string exp)
        {
            
            double result = 0;
            double num1;
            double num2;
            char op;
                num1 = double.Parse(exp.Substring(0, exp.IndexOfAny(operador)));
                num2 = double.Parse(exp.Substring(exp.IndexOfAny(operador) + 1, exp.Length));
                op = exp[exp.IndexOfAny(operador)];

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                }
             

                return result;
            
        }



        private void button_Plus_Click(object sender, EventArgs e)
        {
            if (!siOperador)
            {
                expressionTemp += "+";
            }
            siOperador = true;
            label1.Text = expressionTemp;
        }

        private void button_Less_Click(object sender, EventArgs e)
        {
            if (!siOperador)
            {
                expressionTemp += "-";
            }
            siOperador = true;
            label1.Text = expressionTemp;
        }

        private void button_Times_Click(object sender, EventArgs e)
        {
            if (!siOperador)
            {
                expressionTemp += "*";
            }
            siOperador = true;
            label1.Text = expressionTemp;
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (!siOperador)
            {
                expressionTemp += "/";
            }
            siOperador = true;
            label1.Text = expressionTemp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expressionTemp += 1;
            label1.Text = expressionTemp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expressionTemp += 2;
            label1.Text = expressionTemp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expressionTemp += 3;
            label1.Text = expressionTemp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expressionTemp += 4;
            label1.Text = expressionTemp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expressionTemp += 5;
            label1.Text = expressionTemp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expressionTemp += 6;
            label1.Text = expressionTemp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expressionTemp += 7;
            label1.Text = expressionTemp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expressionTemp += 8;
            label1.Text = expressionTemp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expressionTemp += 9;
            label1.Text = expressionTemp;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            expressionTemp += 0;
            if(expressionTemp.Length == 0)
            {
                label1.Text = "0";
            } else
            {
                expressionTemp += 0;
            }
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            expressionTemp += ".";
        }

        private void button_Sin_Click(object sender, EventArgs e)
        {

        }

        private void button_Cos_Click(object sender, EventArgs e)
        {

        }

        private void button_Tan_Click(object sender, EventArgs e)
        {

        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            if (expressionTemp.Contains(expressionTemp[expressionTemp.IndexOfAny(operador)]))
            {
                label1.Text = resultado(expressionTemp).ToString();
            } else
            {
                label1.Text = expressionTemp;
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {

        }

        private void button_CE_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
