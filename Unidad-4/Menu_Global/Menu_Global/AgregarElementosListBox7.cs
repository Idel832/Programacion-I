using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_AgregarElementosListBox
{
    public partial class AgregarElementosListBox7 : Form
    {
        public AgregarElementosListBox7()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ListBox_Recibir.Items.Add(TxtBox_Send.Text);
            TxtBox_Send.Clear();
        }
    }
}
