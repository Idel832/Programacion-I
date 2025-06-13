using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_MensajeEmergente
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy Idelfonso Peña | MT-2024-00222");
             
        }
    }
}
