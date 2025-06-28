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

namespace _6_NúmeroPerfecto
{
    public partial class VerificarNumPerfecto6 : Form
    {
        public VerificarNumPerfecto6()
        {
            InitializeComponent();
        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            int Num = Convert.ToInt32(MTxtBox_Entrada.Text);
            int suma = 0;

            for (int i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == Num)
                Label_Respuesta.Text = "SI";
            else
                Label_Respuesta.Text = "NO";

            MTxtBox_Entrada.Clear();

        }
    }
}
