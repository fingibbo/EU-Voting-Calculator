namespace EU_Voting_Calculator_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.austriaGroup = new System.Windows.Forms.GroupBox();
            this.austriaCheckBox = new System.Windows.Forms.CheckBox();
            this.austriaCheckYes = new System.Windows.Forms.CheckBox();
            this.austriaCheckNo = new System.Windows.Forms.CheckBox();
            this.austriaCheckAb = new System.Windows.Forms.CheckBox();
            this.austriaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // austriaGroup
            // 
            this.austriaGroup.Controls.Add(this.austriaCheckAb);
            this.austriaGroup.Controls.Add(this.austriaCheckNo);
            this.austriaGroup.Controls.Add(this.austriaCheckYes);
            this.austriaGroup.Controls.Add(this.austriaCheckBox);
            this.austriaGroup.Location = new System.Drawing.Point(12, 65);
            this.austriaGroup.Name = "austriaGroup";
            this.austriaGroup.Size = new System.Drawing.Size(548, 44);
            this.austriaGroup.TabIndex = 0;
            this.austriaGroup.TabStop = false;
            // 
            // austriaCheckBox
            // 
            this.austriaCheckBox.AutoSize = true;
            this.austriaCheckBox.Checked = true;
            this.austriaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.austriaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.austriaCheckBox.Location = new System.Drawing.Point(6, 14);
            this.austriaCheckBox.Name = "austriaCheckBox";
            this.austriaCheckBox.Size = new System.Drawing.Size(84, 24);
            this.austriaCheckBox.TabIndex = 0;
            this.austriaCheckBox.Text = "Austria";
            this.austriaCheckBox.UseVisualStyleBackColor = true;
            this.austriaCheckBox.CheckedChanged += new System.EventHandler(this.austriaCheckBox_CheckedChanged);
            // 
            // austriaCheckYes
            // 
            this.austriaCheckYes.AutoSize = true;
            this.austriaCheckYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.austriaCheckYes.Location = new System.Drawing.Point(294, 14);
            this.austriaCheckYes.Name = "austriaCheckYes";
            this.austriaCheckYes.Size = new System.Drawing.Size(59, 24);
            this.austriaCheckYes.TabIndex = 1;
            this.austriaCheckYes.Text = "Yes";
            this.austriaCheckYes.UseVisualStyleBackColor = true;
            this.austriaCheckYes.CheckedChanged += new System.EventHandler(this.austriaCheckYes_CheckedChanged);
            // 
            // austriaCheckNo
            // 
            this.austriaCheckNo.AutoSize = true;
            this.austriaCheckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.austriaCheckNo.Location = new System.Drawing.Point(359, 14);
            this.austriaCheckNo.Name = "austriaCheckNo";
            this.austriaCheckNo.Size = new System.Drawing.Size(52, 24);
            this.austriaCheckNo.TabIndex = 2;
            this.austriaCheckNo.Text = "No";
            this.austriaCheckNo.UseVisualStyleBackColor = true;
            this.austriaCheckNo.CheckedChanged += new System.EventHandler(this.austriaCheckNo_CheckedChanged);
            // 
            // austriaCheckAb
            // 
            this.austriaCheckAb.AutoSize = true;
            this.austriaCheckAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.austriaCheckAb.Location = new System.Drawing.Point(417, 14);
            this.austriaCheckAb.Name = "austriaCheckAb";
            this.austriaCheckAb.Size = new System.Drawing.Size(87, 24);
            this.austriaCheckAb.TabIndex = 3;
            this.austriaCheckAb.Text = "Abstain";
            this.austriaCheckAb.UseVisualStyleBackColor = true;
            this.austriaCheckAb.CheckedChanged += new System.EventHandler(this.austriaCheckAb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1072, 513);
            this.Controls.Add(this.austriaGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Voting Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.austriaGroup.ResumeLayout(false);
            this.austriaGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox austriaGroup;
        private System.Windows.Forms.CheckBox austriaCheckBox;
        private System.Windows.Forms.CheckBox austriaCheckAb;
        private System.Windows.Forms.CheckBox austriaCheckNo;
        private System.Windows.Forms.CheckBox austriaCheckYes;
    }
}

