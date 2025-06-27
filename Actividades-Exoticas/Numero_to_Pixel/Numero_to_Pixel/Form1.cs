using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Numero_to_Pixel
{
    public partial class Form_Main : Form
    {

        private void ResetMatriz()
        {
            PB00.BackColor = Color.Black;
            PB01.BackColor = Color.Black;
            PB02.BackColor = Color.Black;
            PB03.BackColor = Color.Black;
            PB04.BackColor = Color.Black;
            PB05.BackColor = Color.Black;
            PB06.BackColor = Color.Black;
            PB07.BackColor = Color.Black;
            PB08.BackColor = Color.Black;
            PB09.BackColor = Color.Black;
            PB10.BackColor = Color.Black;
            PB11.BackColor = Color.Black;
            PB12.BackColor = Color.Black;
            PB13.BackColor = Color.Black;
            PB14.BackColor = Color.Black;

        }

        public Form_Main()
        {
            InitializeComponent();
            ResetMatriz();
        }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {

            string Unidad = MTxtBox_Entrada.Text;


            if (Unidad == "1")
            {
                ResetMatriz();

                PB02.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }
            else if (Unidad == "2")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB09.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }
            else if (Unidad == "3")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();

            }

            else if (Unidad == "4")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

            else if (Unidad == "5")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

            else if (Unidad == "6")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB09.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }
            else if (Unidad == "7")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

            else if (Unidad == "8")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB09.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

            else if (Unidad == "9")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB07.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

            else if (Unidad == "0")
            {
                ResetMatriz();

                PB00.BackColor = Color.Blue;
                PB01.BackColor = Color.Blue;
                PB02.BackColor = Color.Blue;
                PB03.BackColor = Color.Blue;
                PB05.BackColor = Color.Blue;
                PB06.BackColor = Color.Blue;
                PB08.BackColor = Color.Blue;
                PB09.BackColor = Color.Blue;
                PB11.BackColor = Color.Blue;
                PB12.BackColor = Color.Blue;
                PB13.BackColor = Color.Blue;
                PB14.BackColor = Color.Blue;

                MTxtBox_Entrada.Clear();
            }

        }

    }
}