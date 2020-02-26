using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU_Voting_Calculator_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void austriaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (austriaCheckBox.Checked == true)
            {
                this.austriaCheckYes.Enabled = true;
                this.austriaCheckNo.Enabled = true;
                this.austriaCheckAb.Enabled = true;
            }
            else
            {
                this.austriaCheckYes.Enabled = false;
                this.austriaCheckNo.Enabled = false;
                this.austriaCheckAb.Enabled = false;
                this.austriaCheckYes.Checked = false;
                this.austriaCheckNo.Checked = false;
                this.austriaCheckAb.Checked = false;

            }
        }

        private void austriaCheckYes_CheckedChanged(object sender, EventArgs e)
        {
            if (austriaCheckYes.Checked == true)
            {
                this.austriaCheckNo.Checked = false;
                this.austriaCheckAb.Checked = false;
            }
            else 
            { 
                
            }
        }

        private void austriaCheckNo_CheckedChanged(object sender, EventArgs e)
        {
            if (austriaCheckNo.Checked == true)
            {
                this.austriaCheckYes.Checked = false;
                this.austriaCheckAb.Checked = false;
            }
            else
            {

            }
        }

        private void austriaCheckAb_CheckedChanged(object sender, EventArgs e)
        {
            if(austriaCheckAb.Checked == true)
            {
                this.austriaCheckYes.Checked = false;
                this.austriaCheckNo.Checked = false;
            }
        }
    }
}
