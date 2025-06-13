using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TransformarTemperaturas
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Btn_Trans_Click(object sender, EventArgs e)
        {
            double Cel = Convert.ToDouble(TxtBox_Celsius.Text);

            double Op = (Cel * 1.8) + 32;


            Label_Result.Text = $"{Op.ToString()} °F";
        }
    }
}
