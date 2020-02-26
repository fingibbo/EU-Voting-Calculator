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
        
        /*
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
            else
            {

            }
        }
        */
        private void belgiumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(!(sender is CheckBox))
            {
                return;
            }
            CheckBox clickedbox = sender as CheckBox;
            foreach(GroupBox box in clickedbox.Parent.Controls.OfType<GroupBox>())
            {
                foreach(CheckBox checkBox in box.Controls.OfType<CheckBox>())
                {
                    checkBox.Enabled = clickedbox.Checked;
                    if(!clickedbox.Checked)
                    {
                        checkBox.CheckedChanged -= bulgariaCheckYes_CheckedChanged;
                        checkBox.Checked = false;
                        checkBox.CheckedChanged += bulgariaCheckYes_CheckedChanged;
                    }
                }
            }
        }
        private void bulgariaCheckYes_CheckedChanged(object sender, EventArgs e)
        {
            if(!(sender is CheckBox))
            {
                return;
            }
            CheckBox clickedbox = sender as CheckBox;
            foreach(CheckBox checkBox in clickedbox.Parent.Controls.OfType<CheckBox>())
            {
                if(clickedbox != checkBox)
                {
                    checkBox.CheckedChanged -= bulgariaCheckYes_CheckedChanged;
                    checkBox.Checked = false;
                    checkBox.CheckedChanged += bulgariaCheckYes_CheckedChanged;
                }
                else
                {
                }
            }
        }
        /*
private void bulgariaCheckBox_CheckedChanged(object sender, EventArgs e)
{
if (bulgariaCheckBox.Checked == true)
{
this.bulgariaCheckYes.Enabled = true;
this.bulgariaCheckNo.Enabled = true;
this.bulgariaCheckAb.Enabled = true;
}
else
{
this.bulgariaCheckYes.Enabled = false;
this.bulgariaCheckNo.Enabled = false;
this.bulgariaCheckAb.Enabled = false;
this.bulgariaCheckYes.Checked = false;
this.bulgariaCheckNo.Checked = false;
this.bulgariaCheckAb.Checked = false;

}

}

private void bulgariaCheckYes_CheckedChanged(object sender, EventArgs e)
{
if (bulgariaCheckYes.Checked == true)
{
this.bulgariaCheckNo.Checked = false;
this.bulgariaCheckAb.Checked = false;
}
else
{

}

}

private void bulgariaCheckNo_CheckedChanged(object sender, EventArgs e)
{
if (bulgariaCheckNo.Checked == true)
{
this.bulgariaCheckYes.Checked = false;
this.bulgariaCheckAb.Checked = false;
}
else
{

}

}

private void bulgariaCheckAb_CheckedChanged(object sender, EventArgs e)
{
if (bulgariaCheckNo.Checked == true)
{
this.bulgariaCheckYes.Checked = false;
this.bulgariaCheckNo.Checked = false;
}
else
{

}

}
*/
    }
}
