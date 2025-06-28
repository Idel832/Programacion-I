using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_VecesPresionadasBoton
{
    public partial class VecesPresionadasBoton8 : Form
    {
        public VecesPresionadasBoton8()
        {
            InitializeComponent();
        }
        
        public int contador = 0;

        private void Btn_Press_Click(object sender, EventArgs e)
        {
            
            contador ++;

            Label_Count.Text = contador.ToString();

        }
    }
}
