using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4_Palabra_Palindroma
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Btn_Verf_Click(object sender, EventArgs e)
        {
            string palabra = TxtBox_Entrada.Text;
            string invertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida += palabra[i];
            }

            if (palabra == invertida)
                Label_Respuesta.Text = "SI";
            else
                Label_Respuesta.Text = "NO";
        }
    }
}
