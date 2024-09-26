using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sonidos;
        private Dictionary<Keys, string> teclas;
        public Form1()
        {
            InitializeComponent();
            sonidos = new Dictionary<string, string>()
            {
                {"DO", @"musica/DO.wav"},
                {"DO#", @"musica/DO#.wav"},
                {"RE", @"musica/RE.wav"},
                {"RE#", @"musica/RE#.wav"},
                {"MI", @"musica/MI.wav"},
                {"FA", @"musica/FA.wav"},
                {"FA#", @"musica/FA#.wav"},
                {"SOL", @"musica/SOL.wav"},
                {"SOL#", @"musica/SOL#.wav"},
                {"LA", @"musica/LA.wav"},
                {"LA#", @"musica/LA#.wav"},
                {"SI", @"musica/SI.wav"},
                {"DOO", @"musica/DoUltimo.wav"}
            };
            teclas = new Dictionary<Keys, string>()
            {
                {Keys.A, "DO"},
                {Keys.W, "DO#"},
                {Keys.S, "RE"},
                {Keys.E, "RE#"},
                {Keys.D, "MI"},
                {Keys.F, "FA"},
                {Keys.T, "FA#"},
                {Keys.G, "SOL"},
                {Keys.Y, "SOL#"},
                {Keys.H, "LA"},
                {Keys.U, "LA#"},
                {Keys.J, "SI"},
                {Keys.K, "DOO"}
            };
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(teclas_presionadas);

        }

        public void reproducirSonido(string sonido)
        {
            if (sonidos.ContainsKey(sonido)) {
                SoundPlayer player = new SoundPlayer(sonidos[sonido]);
                player.Play();
            }
        }

        public void teclas_presionadas(Object sender, KeyEventArgs e) 
        {
            if (teclas.ContainsKey(e.KeyCode))
            {
                label1.Text = teclas[e.KeyCode];
                reproducirSonido(teclas[e.KeyCode]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reproducirSonido("DO");
            label1.Text = "DO";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reproducirSonido("DO#");
            label1.Text = "DO#";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reproducirSonido("RE");
            label1.Text = "RE";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reproducirSonido("RE#");
            label1.Text = "RE#";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reproducirSonido("MI");
            label1.Text = "MI";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reproducirSonido("FA");
            label1.Text = "FA";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reproducirSonido("FA#");
            label1.Text = "FA#";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reproducirSonido("SOL");
            label1.Text = "SOL";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reproducirSonido("SOL#");
            label1.Text = "SOL#";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reproducirSonido("LA");
            label1.Text = "LA";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reproducirSonido("LA#");
            label1.Text = "LA#";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reproducirSonido("SI");
            label1.Text = "SI";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reproducirSonido("DOO");
            label1.Text = "DO";
        }
    }
}
