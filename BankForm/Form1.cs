using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class BankForm : Form
    {
        double CurrentInterest = 2;
        double SavingInterest = 5;
        bool savingsAccount = true;
        int AccountNumber = 0;

        List<Accounts> accounts = new List<Accounts>();
        int AccountSelect = -1;

        public BankForm()
        {
            InitializeComponent();
            bankPanel.Visible = false;
            accountViewPanel.Visible = false;
            addAccountPanel.Visible = false;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            bankPanel.Visible = false;
            accountViewPanel.Visible = false;
            addAccountPanel.Visible = false;
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            bankPanel.Visible = true;
            accountViewPanel.Visible = false;
            addAccountPanel.Visible = false;
            interestConfirmation.Visible = false;
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            bankPanel.Visible = true;
            accountViewPanel.Visible = true;
            addAccountPanel.Visible = false;
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            bankPanel.Visible = true;
            accountViewPanel.Visible = true;
            addAccountPanel.Visible = true;
            creationSuccess.Text = String.Empty;
        }
        //Buttons on Bank Page
        private void addInterest_Click(object sender, EventArgs e)
        {
            foreach (Accounts acc in accounts)
            {
                acc.ApplyInterest();
            }
            interestConfirmation.Visible = true;
            AccountsUpdate();
        }
        //Buttons on Account Page
        private void depositButton_Click(object sender, EventArgs e)
        {
            double DepositAmount = 0;
            Double.TryParse(depositBox.Text, out DepositAmount);
            if (AccountSelect >= 0 && accounts[AccountSelect].Deposit(DepositAmount) && Double.TryParse(depositBox.Text, out DepositAmount))
            {
                transactionResult.Text = "Deposit Successful";
            }
            else
            {
                transactionResult.Text = "Deposit Failed";
            }
            AccountsUpdate();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double WithdrawAmount = 0;
            Double.TryParse(withdrawBox.Text, out WithdrawAmount);
            if (AccountSelect >= 0 && accounts[AccountSelect].Withdraw(WithdrawAmount) && Double.TryParse(withdrawBox.Text, out WithdrawAmount))
            {
                transactionResult.Text = "Withdrawal Successful";
            }
            else
            {
                transactionResult.Text = "Withdrawal Failed";
            }
            AccountsUpdate();
        }

        private void changeOverdraftButton_Click(object sender, EventArgs e)
        {
            if (accounts[AccountSelect].Overdraft == true)
            {
                int NewOverdraftLimit = 0;
                Int32.TryParse(overdraftChange.Text, out NewOverdraftLimit);
                accounts[AccountSelect].OverdraftLimit = NewOverdraftLimit;
                transactionResult.Text = "Overdraft Changed";
            }
            else
            {
                transactionResult.Text = "Overdraft Change Failed. Overdraft unavailable";
            }
        }
        //Buttons on Add Account Page
        private void savingsButton_Click(object sender, EventArgs e)
        {
            overdraftLabel.Visible = false;
            overdraftLimitNew.Visible = false;
            savingsAccount = true;
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            overdraftLabel.Visible = true;
            overdraftLimitNew.Visible = true;
            savingsAccount = false;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            //Take inputs and set them to variables if valid.
            
            string Name = accountName.Text;
            double StartBalance = 0;
            int OverdraftAmount = 0;
            Double.TryParse(accountBalance.Text, out StartBalance);
            if (savingsAccount == false)
            {
                Int32.TryParse(overdraftLimitNew.Text, out OverdraftAmount);
            }

            if (savingsAccount == true) {
                Accounts savingAcc = new Accounts(StartBalance, SavingInterest, Name, AccountNumber);
                accounts.Add(savingAcc);
                AccountSuccess(Name);
            }
            else if (savingsAccount == false)
            {
                Current currentAcc = new Current(StartBalance, CurrentInterest, Name, OverdraftAmount, AccountNumber);
                accounts.Add(currentAcc);
                AccountSuccess(Name);
            }
        }

        //Reused Methods
        public void AccountSuccess(string name) {
            creationSuccess.Text = name + "'s Account has been created!";
            accountName.Text = String.Empty;
            accountBalance.Text = String.Empty;
            overdraftLimitNew.Text = String.Empty;
            accountSelectComboBox.Items.Add(name + " - " +AccountNumber);
            AccountNumber++;
            //DEBUG
            Console.WriteLine("Account added");
        }

        public void AccountsUpdate()
        {
            if (AccountSelect >= 0)
            {
                nameLabel.Text = accounts[AccountSelect].Name;
                balanceLabel.Text = accounts[AccountSelect].ShowBalance().ToString();
            }
        }

        //Fills Combobox with account names and numbers
        private void accountSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountSelect = accountSelectComboBox.SelectedIndex;
            //DEBUG
            Console.WriteLine(AccountSelect);
            AccountsUpdate();
        }

        //Allow only numbers and . in to the input field
        private void accountBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void overdraftLimitNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void depositBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void withdrawBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void overdraftChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}