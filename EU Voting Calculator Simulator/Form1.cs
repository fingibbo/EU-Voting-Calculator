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
        public static int voteMax = 0;
        public static int voteYes = 0;
        public int voteNo = 0;
        public int voteAb = 0;
        public bool passOrNot = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void allCountry_CheckedChanged(object sender, EventArgs e)
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
                        checkBox.CheckedChanged -= allCountryVotes_CheckedChanged;
                        checkBox.Checked = false;
                        checkBox.CheckedChanged += allCountryVotes_CheckedChanged;
                    }
                }
            }
        }
        private void allCountryVotes_CheckedChanged(object sender, EventArgs e)
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
                
                    checkBox.CheckedChanged -= allCountryVotes_CheckedChanged;
                    checkBox.Checked = false;
                    checkBox.CheckedChanged += allCountryVotes_CheckedChanged;
                }
                else
                {
                }
            }
        }

        private void allPartCont_Click(object sender, EventArgs e)
        {
            austriaCheckBox.Checked = true;
            bulgariaCheckBox.Checked = true;
            belgiumCheckBox.Checked = true;
            swedenCheckBox.Checked = true;
            spainCheckBox.Checked = true;
            sloveniaCheckBox.Checked = true;
            slovakiaCheckBox.Checked = true;
            romaniaCheckBox.Checked = true;
            portugalCheckBox.Checked = true;
            polandCheckBox.Checked = true;
            netherlandsCheckBox.Checked = true;
            maltaCheckBox.Checked = true;
            luxembourgCheckBox.Checked = true;
            lithuaniaCheckBox.Checked = true;
            latviaCheckBox.Checked = true;
            italyCheckBox.Checked = true;
            irelandCheckBox.Checked = true;
            hungaryCheckBox.Checked = true;
            greeceCheckBox.Checked = true;
            germanyCheckBox.Checked = true;
            franceCheckBox.Checked = true;
            finlandCheckBox.Checked = true;
            estoniaCheckBox.Checked = true;
            denmarkCheckBox.Checked = true;
            crCheckBox.Checked = true;
            cyprusCheckBox.Checked = true;
            croatiaCheckBox.Checked = true;
        }

        private void eZonePartCont_Click(object sender, EventArgs e)
        {
            austriaCheckBox.Checked = true;
            bulgariaCheckBox.Checked = false;
            belgiumCheckBox.Checked = true;
            swedenCheckBox.Checked = false;
            spainCheckBox.Checked = true;
            sloveniaCheckBox.Checked = true;
            slovakiaCheckBox.Checked = true;
            romaniaCheckBox.Checked = false;
            portugalCheckBox.Checked = true;
            polandCheckBox.Checked = false;
            netherlandsCheckBox.Checked = true;
            maltaCheckBox.Checked = true;
            luxembourgCheckBox.Checked = true;
            lithuaniaCheckBox.Checked = true;
            latviaCheckBox.Checked = true;
            italyCheckBox.Checked = true;
            irelandCheckBox.Checked = true;
            hungaryCheckBox.Checked = false;
            greeceCheckBox.Checked = true;
            germanyCheckBox.Checked = true;
            franceCheckBox.Checked = true;
            finlandCheckBox.Checked = true;
            estoniaCheckBox.Checked = true;
            denmarkCheckBox.Checked = false;
            crCheckBox.Checked = false;
            cyprusCheckBox.Checked = true;
            croatiaCheckBox.Checked = false;

        }

        private void allYes_Click(object sender, EventArgs e)
        {
            austriaCheckBox.Checked = true;
            bulgariaCheckBox.Checked = true;
            belgiumCheckBox.Checked = true;
            swedenCheckBox.Checked = true;
            spainCheckBox.Checked = true;
            sloveniaCheckBox.Checked = true;
            slovakiaCheckBox.Checked = true;
            romaniaCheckBox.Checked = true;
            portugalCheckBox.Checked = true;
            polandCheckBox.Checked = true;
            netherlandsCheckBox.Checked = true;
            maltaCheckBox.Checked = true;
            luxembourgCheckBox.Checked = true;
            lithuaniaCheckBox.Checked = true;
            latviaCheckBox.Checked = true;
            italyCheckBox.Checked = true;
            irelandCheckBox.Checked = true;
            hungaryCheckBox.Checked = true;
            greeceCheckBox.Checked = true;
            germanyCheckBox.Checked = true;
            franceCheckBox.Checked = true;
            finlandCheckBox.Checked = true;
            estoniaCheckBox.Checked = true;
            denmarkCheckBox.Checked = true;
            crCheckBox.Checked = true;
            cyprusCheckBox.Checked = true;
            croatiaCheckBox.Checked = true;

            austriaCheckYes.Checked = true;
            bulgariaCheckYes.Checked = true;
            belgiumCheckYes.Checked = true;
            swedenCheckYes.Checked = true;
            spainCheckYes.Checked = true;
            sloveniaCheckYes.Checked = true;
            slovakiaCheckYes.Checked = true;
            romaniaCheckYes.Checked = true;
            portugalCheckYes.Checked = true;
            polandCheckYes.Checked = true;
            netherlandsCheckYes.Checked = true;
            maltaCheckYes.Checked = true;
            luxembourgCheckYes.Checked = true;
            lithuaniaCheckYes.Checked = true;
            latviaCheckYes.Checked = true;
            italyCheckYes.Checked = true;
            irelandCheckYes.Checked = true;
            hungaryCheckYes.Checked = true;
            greeceCheckYes.Checked = true;
            germanyCheckYes.Checked = true;
            franceCheckYes.Checked = true;
            finlandCheckYes.Checked = true;
            estoniaCheckYes.Checked = true;
            denmarkCheckYes.Checked = true;
            crCheckYes.Checked = true;
            cyprusCheckYes.Checked = true;
            croatiaCheckYes.Checked = true;
        }

        private void submitVotesButton_Click(object sender, EventArgs e)
        {
            voteMax = 0;
            voteYes = 0;
            voteNo = 0;
            voteAb = 0;
            foreach(GroupBox box in submitVotesButton.Parent.Controls.OfType<GroupBox>())
            {

                foreach (GroupBox innerBox in box.Controls.OfType<GroupBox>())
                {


                    foreach(CheckBox checkBox in innerBox.Controls.OfType<CheckBox>())
                    {
                        if (checkBox.Checked == true && checkBox.Text == "Yes")
                        {
                            voteYes += 1;
                            voteMax += 1;
                        }
                        if (checkBox.Checked == true && checkBox.Text == "No")
                        {
                            voteNo += 1;
                            voteMax += 1;
                        }
                        if (checkBox.Checked == true && checkBox.Text == "Abstain")
                        {
                            voteAb += 1;
                            voteMax += 1;
                        }
                    }
                }
            }
            voteMaxLabel.Text = "Participating Countries: " + Convert.ToString(voteMax);
            voteYesLabel.Text = "Countries Voting Yes: " + Convert.ToString(voteYes);
            voteNoLabel.Text = "Countries Voting No: " + Convert.ToString(voteNo);
            voteAbLabel.Text = "Countries Abstaining: " + Convert.ToString(voteAb);
        }

        private void ruleQualMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (ruleQualMaj.Checked == true)
            {
                ruleReinQualMaj.Checked = false;
                ruleSimpMaj.Checked = false;
                ruleUnanimity.Checked = false;
                ruleExpLabel.Text = "Rule Explanation: Minimum “Yes” required for adoption is 55%";
            }
        }

        private void ruleReinQualMaj_CheckedChanged(object sender, EventArgs e)
        {
            if(ruleReinQualMaj.Checked == true)
            {
                ruleQualMaj.Checked = false;
                ruleSimpMaj.Checked = false;
                ruleUnanimity.Checked = false;
                ruleExpLabel.Text = "Rule Explanation: Minimum “Yes” required for adoption is 72%";
            }

        }

        private void ruleSimpMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (ruleSimpMaj.Checked == true)
            {
                ruleQualMaj.Checked = false;
                ruleReinQualMaj.Checked = false;
                ruleUnanimity.Checked = false;
                ruleExpLabel.Text = "Rule Explanation: Minimum “Yes” required for adoption is 50%";
            }
        }

        private void ruleUnanimity_CheckedChanged(object sender, EventArgs e)
        {
            if(ruleUnanimity.Checked == true)
            {
                ruleQualMaj.Checked = false;
                ruleReinQualMaj.Checked = false;
                ruleSimpMaj.Checked = false;
                ruleExpLabel.Text = "Rule Explanation: Minimum “Yes” required for adoption is 100%";
            }

        }

        private void submitRuleButton_Click(object sender, EventArgs e)
        {
            if(voteMax >= 1) 
            {
                double votePercent = ((double)voteYes / voteMax) * 100;
                decimal votePCon = Convert.ToDecimal(votePercent);
                votePCon = Math.Round(votePCon, 2);
                foreach (CheckBox checkBox in submitRuleButton.Parent.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked == true && checkBox.Text == "Qualified Majority")
                    {
                        if (votePercent >= 55.0)
                        {
                            voteResultLabel.Text = "Vote has passed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                        if (votePercent < 55.0)
                        {
                            voteResultLabel.Text = "Vote has failed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                    }
                    if (checkBox.Checked == true && checkBox.Text == "Reinforced Qualified Majority")
                    {
                        if (votePercent >= 72.0)
                        {
                            voteResultLabel.Text = "Vote has passed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                        if (votePercent < 72.0)
                        {
                            voteResultLabel.Text = "Vote has failed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                    }
                    if (checkBox.Checked == true && checkBox.Text == "Simple Majority")
                    {
                        if (votePercent >= 50.0)
                        {
                            voteResultLabel.Text = "Vote has passed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                        if (votePercent < 50.0)
                        {
                            voteResultLabel.Text = "Vote has failed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                    }
                    if (checkBox.Checked == true && checkBox.Text == "Unanimity")
                    {
                        if (votePercent == 100.0)
                        {
                            voteResultLabel.Text = "Vote has passed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                        if (votePercent < 100.0)
                        {
                            voteResultLabel.Text = "Vote has failed with " + Convert.ToString(votePCon) + "% of votes.";
                        }
                    }
                }
            }
        }
    }
}
