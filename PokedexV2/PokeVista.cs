using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexV2
{
    public partial class PokeVista : UserControl
    {
        public PokeVista(string nombre, Image imagen)
        {
            InitializeComponent();
            this.nombre.Text = nombre;
            this.imagen.Image = imagen;
        }

        private void PokeVista_Load(object sender, EventArgs e)
        {

        }
    }
}
