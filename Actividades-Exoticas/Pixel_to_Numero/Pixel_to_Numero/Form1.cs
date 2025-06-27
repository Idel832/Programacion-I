using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_to_Numero
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

        private void PB_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb != null)
            {
                pb.BackColor = pb.BackColor == Color.Blue ? Color.Black : Color.Blue;
            }
        }

        private void Btn_LimpiarPB_Click(object sender, EventArgs e)
        {
            ResetMatriz();
            Label_Respuesta.Text = "..."; 
        }

        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB09.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB04.BackColor == Color.Black &&
                PB07.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "0";
            }
            else if (
                PB02.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB00.BackColor == Color.Black &&
                PB01.BackColor == Color.Black &&
                PB03.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB06.BackColor == Color.Black &&
                PB07.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black &&
                PB12.BackColor == Color.Black &&
                PB13.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "1";
            }
            else if (
                PB01.BackColor == Color.Blue &&
                PB04.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB10.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&

                PB00.BackColor == Color.Black &&
                PB02.BackColor == Color.Black &&
                PB03.BackColor == Color.Black &&
                PB05.BackColor == Color.Black &&
                PB06.BackColor == Color.Black &&
                PB08.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB11.BackColor == Color.Black &&
                PB12.BackColor == Color.Black &&
                PB14.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "1";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB09.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&

                PB01.BackColor == Color.Black &&
                PB02.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB05.BackColor == Color.Black &&
                PB07.BackColor == Color.Black &&
                PB08.BackColor == Color.Black &&
                PB10.BackColor == Color.Black &&
                PB11.BackColor == Color.Black &&
                PB13.BackColor == Color.Black &&
                PB14.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "1";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB09.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB03.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB10.BackColor == Color.Black &&
                PB11.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "2";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB03.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "3";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB03.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB06.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "3";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB01.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black &&
                PB12.BackColor == Color.Black &&
                PB13.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "4";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB04.BackColor == Color.Black &&
                PB05.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "5";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB09.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB04.BackColor == Color.Black &&
                PB05.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "6";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB03.BackColor == Color.Black &&
                PB04.BackColor == Color.Black &&
                PB06.BackColor == Color.Black &&
                PB07.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black &&
                PB12.BackColor == Color.Black &&
                PB13.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "7";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB09.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB04.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "8";
            }
            else if (
                PB00.BackColor == Color.Blue &&
                PB01.BackColor == Color.Blue &&
                PB02.BackColor == Color.Blue &&
                PB03.BackColor == Color.Blue &&
                PB05.BackColor == Color.Blue &&
                PB06.BackColor == Color.Blue &&
                PB07.BackColor == Color.Blue &&
                PB08.BackColor == Color.Blue &&
                PB11.BackColor == Color.Blue &&
                PB12.BackColor == Color.Blue &&
                PB13.BackColor == Color.Blue &&
                PB14.BackColor == Color.Blue &&

                PB04.BackColor == Color.Black &&
                PB09.BackColor == Color.Black &&
                PB10.BackColor == Color.Black
            )
            {
                Label_Respuesta.Text = "9";
            }
            else
            {
                MessageBox.Show("No coincide con ningún número, intentalo otra vez");
                return;
            }
        }
    }
}