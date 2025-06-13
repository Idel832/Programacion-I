using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_ProgressBar
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            this.PgressBar_Timer.Start();
        }

        private void PgressBar_Timer_Tick(object sender, EventArgs e)
        {
            this.PgrssBar_1.Increment(1);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            this.PgressBar_Timer.Stop();
        }
    }
}
