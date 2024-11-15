using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        UsuarioService userSer = new UsuarioService();
        public Form1()
        {
          
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(userSer.existeUser(username, password)){
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuario/contrasena no existe.");
            }
            
        }

        private bool ValidarLogin(string username, string password)
        {
            return username == "xortiz@uabc.edu.mx" && password == "contra";
        }
    }
}
