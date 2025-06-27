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

namespace _8_ConteoPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            string oracion = TxtBox_Entrada.Text;
            string[] palabras = oracion.Split(' ');
            int cantidad = 0;

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] != "")
                {
                    cantidad++;
                }
            }


            Label_RptOra.Text = $"- {TxtBox_Entrada.Text}";
            Label_Resultado.Text = $"{cantidad.ToString()} palabras.";

            TxtBox_Entrada.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
