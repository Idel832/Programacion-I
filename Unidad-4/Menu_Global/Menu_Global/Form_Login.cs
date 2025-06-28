using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Global
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (TxtBox_Login_Nombre.Text == "Idelfonso" && TxtBox_Login_Contr.Text == "MT-2024-00222")
            {
                Form_MenuMain menu = new Form_MenuMain();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
