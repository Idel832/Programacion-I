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

namespace Mostrar_TablaMultiplicar
{
    public partial class MostrarTablaMultiplicar1 : Form
    {
        public MostrarTablaMultiplicar1()
        {
            InitializeComponent();
        }

        private void TxtBox_IngresarNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            ListBox_Tabla.Items.Clear();
            

            if (int.TryParse(TxtBox_IngresarNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    ListBox_Tabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtBox_IngresarNumero.Clear();
        }
    }
}
