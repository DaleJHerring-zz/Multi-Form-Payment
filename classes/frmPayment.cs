using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            ccListBox.Items.Add("Visa");
            ccListBox.Items.Add("Mastercard");
            ccListBox.Items.Add("American Express");
            ccListBox.SelectedIndex = 0;
            string[] months = { "Select a month...", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                monthBox.Items.Add(month);
            }
                monthBox.SelectedIndex = 0;
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            yearBox.Items.Add("Select a year...");
            while (year < endYear)
            {
                yearBox.Items.Add(year); year++;
            }
            yearBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                this.SaveData();
            }
        }

        private void Billing_CheckChanged(object sender, EventArgs e)
        {
            if (creditRB.Checked)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        private void EnableControls()
        {
            ccListBox.Enabled = true;
            ccNumberBox.Enabled = true;
            monthBox.Enabled = true;
            yearBox.Enabled = true;
        }

        private void DisableControls()
        {
            ccListBox.Enabled = false;
            ccNumberBox.Enabled = false;
            monthBox.Enabled = false;
            yearBox.Enabled = false;
        }

        private bool IsValidData()
        {
            if (creditRB.Checked)
            {
                if (ccListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ccListBox.Focus();
                    return false;
                }
                if (ccNumberBox.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ccNumberBox.Focus();
                    return false;
                }
                if (monthBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    monthBox.Focus();
                    return false;
                }
                if (yearBox.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    yearBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;
            if (creditRB.Checked == true)
            {
                msg += "Charge to credit card." + "\n";
                msg += "\n";
                msg += "Card type: " + ccListBox.Text + "\n";
                msg += "Card number: " + ccNumberBox.Text + "\n";
                msg += "Expiration date: " + monthBox.Text + "/" + yearBox.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n";
                msg += "\n";
            }
            bool isDefaultBilling = dbChkBox.Checked;
            msg += "Default billing: " + isDefaultBilling;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

    }//end class
}//end namespace
