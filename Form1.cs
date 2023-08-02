//Anri van Tonder
//37328409

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak6._1_37328409
{
    public partial class frmInterestCalculator : Form
    {
        public frmInterestCalculator()
        {
            InitializeComponent();
        }

        /*private void label2_Click(object sender, EventArgs e)
        {

        }*/

        //Close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables
            double InitialAmount, InterestRate, FinalAmount;
            int YearsInvested, i = 1;

            //initialize variables
            if (double.TryParse(txtInitial.Text, out InitialAmount)) { }
            else
            {
                MessageBox.Show("The wrong value was given.");
                txtInitial.Clear();
                txtInitial.Focus();
            }

            if (int.TryParse(txtInvested.Text, out YearsInvested)) { }
            else
            {
                MessageBox.Show("The wrong value was given.");
                txtInvested.Clear();
                txtInvested.Focus();
            }

            if (double.TryParse(txtInterestRate.Text, out InterestRate)) 
            {
                InterestRate = InterestRate / 100;
            }
            else
            {
                MessageBox.Show("The wrong value was given.");
                txtInterestRate.Clear();
                txtInterestRate.Focus();
            }


            //While for calculating and showing the output
            while (i <= YearsInvested)
            {
                //Calculate the final amount
                FinalAmount = InitialAmount * Math.Pow((1 + InterestRate), i);
                //Output
                lbxAmount.Items.Add("After " + i + " years the amount is: R" +
                    FinalAmount.ToString("f2"));
                //increase counter
                i++;
            }
        }
    }
}
