using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_MostrarFecha
{
    public partial class MostrarFecha11 : Form
    {
        public MostrarFecha11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label_Transfer.Text = DTP_Transfer.Text;
        }
    }
}
