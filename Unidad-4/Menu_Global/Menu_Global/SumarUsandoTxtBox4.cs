using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_SumarUsandoTxtBox
{
    public partial class SumarUsandoTxtBox4 : Form
    {
        public SumarUsandoTxtBox4()
        {
            InitializeComponent();
        }

        private void Btn_Sumar_Click(object sender, EventArgs e)
        {
            Double Num1 = Convert.ToDouble(TxtBox_FirstN.Text);
            Double Num2 = Convert.ToDouble(Txt_SecondN.Text);
            Double Resultado = Num1 + Num2;

            Label_OperationResult.Text = Resultado.ToString();
        }
    }
}
