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

namespace _5_Verificación_Primo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            int Num = Convert.ToInt32(MTextBox_Entrada.Text);
            bool Verif = true;

            if (Num <= 1)
                Verif = false;
            else
            {
                for (int i = 2; i < Num; i++)
                {
                    if (Num % i == 0)
                    {
                        Verif = false;
                        break;
                    }
                }
            }

            if (Verif)
                Label_Respuesta.Text = "SI";
            else
                Label_Respuesta.Text = "NO";

            MTextBox_Entrada.Clear();
        }
    }
}
