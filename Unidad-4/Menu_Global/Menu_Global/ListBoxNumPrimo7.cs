using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Listbox_NumerosPrimos
{
    public partial class ListBoxNumPrimo7 : Form
    {
        public ListBoxNumPrimo7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            int Inicio = Convert.ToInt32(MTxtBox_Inicio.Text);
            int Fin = Convert.ToInt32(MTxtBox_Final.Text);

            ListBox_Resultado.Items.Clear();

            for (int n = Inicio; n <= Fin; n++)

            {
                bool Primo = true;

                if (n <= 1)
                    Primo = false;
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            Primo = false;
                            break;
                        }
                    }
                }

                if (Primo)
                    ListBox_Resultado.Items.Add(n);

            MTxtBox_Final.Clear();
            MTxtBox_Inicio.Clear();
            }
        }
    }
}
