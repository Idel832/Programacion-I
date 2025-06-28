using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_Temporizador
{
    public partial class Temporizador2 : Form
    {
        int TiempoRestMostrar = 0;
        public Temporizador2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            bool minOK = int.TryParse(TxtBox_Mins.Text, out int minutos);
            bool segOK = int.TryParse(TxtBox_Segs.Text, out int segundos);

            if (!minOK || !segOK || minutos < 0 || segundos < 0 || segundos >= 60)
            {
                MessageBox.Show("Ingresa valores válidos para minutos y segundos.\nSegundos debe ser menor de 60.");
                return;
            }

            TiempoRestMostrar = (minutos * 60) + segundos;

            if (TiempoRestMostrar == 0)
            {
                MessageBox.Show("El tiempo debe ser mayor a cero.");
                return;
            }

            ActualizarLabelTiempo();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TiempoRestMostrar > 0)
            {
                TiempoRestMostrar--;
                ActualizarLabelTiempo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡El tiempo se acabó!");
            }
        }

        private void ActualizarLabelTiempo()
        {
            int minutos = TiempoRestMostrar / 60;
            int segundos = TiempoRestMostrar % 60;
            Label_Tiempo.Text = $"{minutos:D2}:{segundos:D2}";
        }
            


    }
}
