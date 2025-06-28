using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_ConvertirUnidades
{
    public partial class ConvertirUnidades3 : Form
    {
        public ConvertirUnidades3()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(TxtBox_Entrada.Text);
            string Entrada = ComboBox_Entrada.Text;
            string Salida = ComboBox_Salida.Text;
            double resultado = 0;

            if (Entrada == "Metros")
                resultado = valor;

            else if (Entrada == "Centímetros")
                resultado = valor / 100;

            else if (Entrada == "Pulgadas")
                resultado = valor * 0.0254;

            if (Salida == "Metros")
                resultado = resultado;

            else if (Salida == "Centímetros")
                resultado = resultado * 100;

            else if (Salida == "Pulgadas")
                resultado = resultado / 0.0254;

            Label_Salida.Text = resultado.ToString();
        }
    }
}
