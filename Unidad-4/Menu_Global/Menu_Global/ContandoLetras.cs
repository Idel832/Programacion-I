using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContandoLetrasOracion
{
    public partial class ContandoLetras : Form
    {
        public ContandoLetras()
        {
            InitializeComponent();
        }

        private void Btn_Analizar_Click(object sender, EventArgs e)
        {

            string oracion = TxtBox_Escribe.Text.ToUpper();


            Dictionary<char, int> conteo = new Dictionary<char, int>();


            foreach (char c in oracion)
            {

                if (char.IsLetter(c))
                {

                    if (conteo.ContainsKey(c))
                    {
                        conteo[c]++;
                    }

                    else
                    {
                        conteo[c] = 1;
                    }
                }
            }

            ListBox_Analizar.Items.Clear();

            foreach (var letra in conteo)
            {

                ListBox_Analizar.Items.Add(letra.Key + ": " + letra.Value);
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            ListBox_Analizar.Items.Clear();
            TxtBox_Escribe.Clear();
        }
    }
}
