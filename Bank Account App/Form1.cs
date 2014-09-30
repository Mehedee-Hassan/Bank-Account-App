using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_App
{
    public partial class PersonUIForm : Form
    {
        public PersonUIForm()
        {

            InitializeComponent();
            amountTextBox.Text = "0";
            depositButton.Enabled = false;
            widthdrawButton.Enabled = false;
        }

        private Account aAccount;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aAccount = new Account();
            
            aAccount.Name = accountNumberTextBox.Text;
            aAccount.Number = accountNumberTextBox.Text;



            accountNumberTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;


            depositButton.Enabled = true;
            widthdrawButton.Enabled = true;

        }

        private void depositButton_Click(object sender, EventArgs e)
        {

            double amount = 0;

            if (amountTextBox.Text != "")
                amount = Convert.ToDouble(amountTextBox.Text);

            aAccount.Depsit(amount);
            
            aAccount.Depsit(amount);
            amountTextBox.Text = string.Empty;
        }

        private void widthdraw_Click(object sender, EventArgs e)
        {
            double amount = 0;

            if (amountTextBox.Text != "")
                amount = Convert.ToDouble(amountTextBox.Text);
                
            aAccount.Widthdraw(amount);
            
            
            amountTextBox.Text = string.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string message = aAccount.Name + " , Your Current Balance is : " + aAccount.Balance;

            MessageBox.Show(message);
            
        }

    }
}
