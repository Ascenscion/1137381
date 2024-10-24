using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cb_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Mostrar.Checked)
            {
                tb_Contra.PasswordChar = '\0';
            }
            else
            {
                tb_Contra.PasswordChar = '*';
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            string username = tb_Usuario.Text;
            string password = tb_Contra.Text;
            if(ValidarLogin(username, password))
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usario o Contrasena no valida.");
            }
        }

        private bool ValidarLogin(string username, string password)
        {
            return username == "xortiz@uabc.edu.mx" && password == "contra";
        }
    }
}
