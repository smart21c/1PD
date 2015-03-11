using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1PD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //ESC키로 프로그램 종료
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }  

        private void btn_HRtoPD_Click(object sender, EventArgs e)
        {
            double PD;
            PD = Convert.ToDouble((textBox_HR.Text)) / 8;
            textBox_PD.Text = Convert.ToString(PD);
        }

        private void btn_PDtoHR_Click(object sender, EventArgs e)
        {
            double HR;
            HR = Convert.ToDouble((textBox_PD.Text)) * 8;
            textBox_HR.Text = Convert.ToString(HR);
        }

        private void HRtoPD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double PD;
                PD = Convert.ToDouble((textBox_HR.Text)) / 8;
                textBox_PD.Text = Convert.ToString(PD);
            }
        }

        private void PDtoHR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double HR;
                HR = Convert.ToDouble((textBox_PD.Text)) * 8;
                textBox_HR.Text = Convert.ToString(HR);
            }
        }
    }
}
