using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_ValidaciónTextBox
{
    public partial class ValidaciónTextBox9 : Form
    {
        public ValidaciónTextBox9()
        {
            InitializeComponent();
        }

        private void Btn_Validate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtBox_Validate.Text, out double result))

                Label_Test.Text = "Es un número | Dato valido";

            else

                Label_Test.Text = "El dato ingresado no es un número";


        }
    }
}
