using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsonA
{
    public partial class Form1 : Form
    {
        List<Usuario> user = new List<Usuario>();
        async Task Main()
        {
            string aprURL = "https://jsonplaceholder.typicode.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(aprURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        user = JsonConvert.DeserializeObject<List<Usuario>>(jsonContent);
                        dataGridView1.DataSource = user;
                        
                    }
                    else
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }

}
