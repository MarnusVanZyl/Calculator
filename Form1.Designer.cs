
namespace Prak6._1_37328409
{
    partial class frmInterestCalculator
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
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblYearsInvested = new System.Windows.Forms.Label();
            this.lblInterestRAte = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtInvested = new System.Windows.Forms.TextBox();
            this.lbxAmount = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(182, 48);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(115, 13);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Initial amount invested:";
            // 
            // lblYearsInvested
            // 
            this.lblYearsInvested.AutoSize = true;
            this.lblYearsInvested.Location = new System.Drawing.Point(217, 84);
            this.lblYearsInvested.Name = "lblYearsInvested";
            this.lblYearsInvested.Size = new System.Drawing.Size(80, 13);
            this.lblYearsInvested.TabIndex = 1;
            this.lblYearsInvested.Text = "Years invested:";
            // 
            // lblInterestRAte
            // 
            this.lblInterestRAte.AutoSize = true;
            this.lblInterestRAte.Location = new System.Drawing.Point(231, 125);
            this.lblInterestRAte.Name = "lblInterestRAte";
            this.lblInterestRAte.Size = new System.Drawing.Size(66, 13);
            this.lblInterestRAte.TabIndex = 2;
            this.lblInterestRAte.Text = "Interest rate:";
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(346, 48);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(100, 20);
            this.txtInitial.TabIndex = 0;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(346, 125);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 2;
            // 
            // txtInvested
            // 
            this.txtInvested.Location = new System.Drawing.Point(346, 84);
            this.txtInvested.Name = "txtInvested";
            this.txtInvested.Size = new System.Drawing.Size(100, 20);
            this.txtInvested.TabIndex = 1;
            // 
            // lbxAmount
            // 
            this.lbxAmount.FormattingEnabled = true;
            this.lbxAmount.Location = new System.Drawing.Point(185, 173);
            this.lbxAmount.Name = "lbxAmount";
            this.lbxAmount.Size = new System.Drawing.Size(261, 121);
            this.lbxAmount.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(222, 325);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbxAmount);
            this.Controls.Add(this.txtInvested);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.lblInterestRAte);
            this.Controls.Add(this.lblYearsInvested);
            this.Controls.Add(this.lblInitial);
            this.Name = "frmInterestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblYearsInvested;
        private System.Windows.Forms.Label lblInterestRAte;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtInvested;
        private System.Windows.Forms.ListBox lbxAmount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

