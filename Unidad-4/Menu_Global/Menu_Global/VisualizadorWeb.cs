using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_Web
{
    public partial class VisualizadorWeb : Form
    {
        public VisualizadorWeb()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string URL = TxtBox_URL.Text.Trim();
            
            Web_Browser.Navigate(URL);
            
        }
    }
}
