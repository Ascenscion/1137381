using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12
{
    public partial class Form1 : Form
    {
        string archivo;
        FontStyle negrita = new FontStyle();
        FontStyle italica = new FontStyle();
        FontStyle subrayado = new FontStyle();
        FontStyle tachado = new FontStyle();
        PrintDocument printDocument = new PrintDocument();
        public Form1()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";
            if(archivo != null)
            {
                using(StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            else
            {
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
            string nombreArchivo = Path.GetFileName(archivo);
            MessageBox.Show("'" + nombreArchivo + "'" + "se a guardado con exito" + " en: " + archivo); //Falta el nombre del archivo
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(richTextBox1.SelectedText);
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            richTextBox1.Text = (string)iData.GetData(DataFormats.Text);
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void mayusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Text = richTextBox1.Text.ToUpper();
        }

        private void minusculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToLower();
        }

        private void negritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (negrita == FontStyle.Bold)
            {
                negrita = FontStyle.Regular;
            } else
            {
                negrita = FontStyle.Bold;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, negrita | subrayado | italica |tachado);
        }

        private void italicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (italica == FontStyle.Italic)
            {
                italica = FontStyle.Regular;
            }
            else
            {
                italica = FontStyle.Italic;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, italica | subrayado | negrita | tachado);
        }

        private void subrayadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(subrayado == FontStyle.Underline)
            {
                subrayado = FontStyle.Regular;
            } else
            {
                subrayado = FontStyle.Underline;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, subrayado | negrita | italica | tachado);
        }

        private void tachadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tachado == FontStyle.Strikeout)
            {
                tachado = FontStyle.Regular;
            } else
            {
                tachado = FontStyle.Strikeout;
            }
            richTextBox1.Font = new Font(richTextBox1.Font, tachado | negrita | subrayado | italica);  
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string contenido = richTextBox1.Text;
            e.Graphics.DrawString(contenido, new Font("Arial", 12), Brushes.Black, 100, 100);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void derechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
