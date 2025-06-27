using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keylogger
{
    public partial class Principal_Intf : Form
    {
        public Principal_Intf()
        {
            InitializeComponent();
        }

        private void Keylogger_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Keylogger_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtBox_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListBox_Keylogger.Items.Add(e.KeyChar.ToString());
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TxtBox_Input.Clear();
            ListBox_Keylogger.Items.Clear();
        }
    }
}
