namespace BankForm
{
    partial class BankForm
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
            this.homeButton = new System.Windows.Forms.Button();
            this.bankButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.bankPanel = new System.Windows.Forms.Panel();
            this.accountViewPanel = new System.Windows.Forms.Panel();
            this.addAccountPanel = new System.Windows.Forms.Panel();
            this.overdraftLimitNew = new System.Windows.Forms.TextBox();
            this.accountBalance = new System.Windows.Forms.TextBox();
            this.creationSuccess = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.currentButton = new System.Windows.Forms.Button();
            this.savingsButton = new System.Windows.Forms.Button();
            this.overdraftLabel = new System.Windows.Forms.Label();
            this.startBalance = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.changeOverdraftButton = new System.Windows.Forms.Button();
            this.overdraftLimit = new System.Windows.Forms.Label();
            this.balanceAccount = new System.Windows.Forms.Label();
            this.accountSelectComboBox = new System.Windows.Forms.ComboBox();
            this.transactionResult = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.withdrawBox = new System.Windows.Forms.TextBox();
            this.overdraftChange = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.addInterest = new System.Windows.Forms.Button();
            this.interestConfirmation = new System.Windows.Forms.Label();
            this.bankPanel.SuspendLayout();
            this.accountViewPanel.SuspendLayout();
            this.addAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(12, 25);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 30);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // bankButton
            // 
            this.bankButton.Location = new System.Drawing.Point(12, 75);
            this.bankButton.Name = "bankButton";
            this.bankButton.Size = new System.Drawing.Size(100, 30);
            this.bankButton.TabIndex = 1;
            this.bankButton.Text = "Bank View";
            this.bankButton.UseVisualStyleBackColor = true;
            this.bankButton.Click += new System.EventHandler(this.bankButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.Location = new System.Drawing.Point(12, 125);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(100, 30);
            this.accountButton.TabIndex = 2;
            this.accountButton.Text = "Accounts";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(12, 175);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(100, 30);
            this.addAccount.TabIndex = 3;
            this.addAccount.Text = "Add Account";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // bankPanel
            // 
            this.bankPanel.Controls.Add(this.accountViewPanel);
            this.bankPanel.Controls.Add(this.addInterest);
            this.bankPanel.Controls.Add(this.interestConfirmation);
            this.bankPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bankPanel.Location = new System.Drawing.Point(118, 0);
            this.bankPanel.Name = "bankPanel";
            this.bankPanel.Size = new System.Drawing.Size(799, 529);
            this.bankPanel.TabIndex = 4;
            this.bankPanel.Visible = false;
            // 
            // accountViewPanel
            // 
            this.accountViewPanel.Controls.Add(this.addAccountPanel);
            this.accountViewPanel.Controls.Add(this.accountNameLabel);
            this.accountViewPanel.Controls.Add(this.withdrawButton);
            this.accountViewPanel.Controls.Add(this.depositButton);
            this.accountViewPanel.Controls.Add(this.changeOverdraftButton);
            this.accountViewPanel.Controls.Add(this.overdraftLimit);
            this.accountViewPanel.Controls.Add(this.balanceAccount);
            this.accountViewPanel.Controls.Add(this.accountSelectComboBox);
            this.accountViewPanel.Controls.Add(this.transactionResult);
            this.accountViewPanel.Controls.Add(this.depositBox);
            this.accountViewPanel.Controls.Add(this.withdrawBox);
            this.accountViewPanel.Controls.Add(this.overdraftChange);
            this.accountViewPanel.Controls.Add(this.nameLabel);
            this.accountViewPanel.Controls.Add(this.balanceLabel);
            this.accountViewPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.accountViewPanel.Location = new System.Drawing.Point(0, 0);
            this.accountViewPanel.Name = "accountViewPanel";
            this.accountViewPanel.Size = new System.Drawing.Size(799, 529);
            this.accountViewPanel.TabIndex = 2;
            this.accountViewPanel.Visible = false;
            // 
            // addAccountPanel
            // 
            this.addAccountPanel.Controls.Add(this.overdraftLimitNew);
            this.addAccountPanel.Controls.Add(this.accountBalance);
            this.addAccountPanel.Controls.Add(this.creationSuccess);
            this.addAccountPanel.Controls.Add(this.createAccount);
            this.addAccountPanel.Controls.Add(this.currentButton);
            this.addAccountPanel.Controls.Add(this.savingsButton);
            this.addAccountPanel.Controls.Add(this.overdraftLabel);
            this.addAccountPanel.Controls.Add(this.startBalance);
            this.addAccountPanel.Controls.Add(this.accountLabel);
            this.addAccountPanel.Controls.Add(this.accountName);
            this.addAccountPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.addAccountPanel.Name = "addAccountPanel";
            this.addAccountPanel.Size = new System.Drawing.Size(799, 529);
            this.addAccountPanel.TabIndex = 9;
            this.addAccountPanel.Visible = false;
            // 
            // overdraftLimitNew
            // 
            this.overdraftLimitNew.Location = new System.Drawing.Point(124, 171);
            this.overdraftLimitNew.Name = "overdraftLimitNew";
            this.overdraftLimitNew.Size = new System.Drawing.Size(100, 20);
            this.overdraftLimitNew.TabIndex = 11;
            this.overdraftLimitNew.Visible = false;
            this.overdraftLimitNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.overdraftLimitNew_KeyPress);
            // 
            // accountBalance
            // 
            this.accountBalance.Location = new System.Drawing.Point(124, 89);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(100, 20);
            this.accountBalance.TabIndex = 6;
            this.accountBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountBalance_KeyPress);
            // 
            // creationSuccess
            // 
            this.creationSuccess.AutoSize = true;
            this.creationSuccess.Location = new System.Drawing.Point(31, 222);
            this.creationSuccess.Name = "creationSuccess";
            this.creationSuccess.Size = new System.Drawing.Size(0, 13);
            this.creationSuccess.TabIndex = 9;
            // 
            // createAccount
            // 
            this.createAccount.BackColor = System.Drawing.Color.YellowGreen;
            this.createAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.createAccount.Location = new System.Drawing.Point(291, 165);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(100, 30);
            this.createAccount.TabIndex = 8;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = false;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // currentButton
            // 
            this.currentButton.Location = new System.Drawing.Point(124, 125);
            this.currentButton.Name = "currentButton";
            this.currentButton.Size = new System.Drawing.Size(100, 30);
            this.currentButton.TabIndex = 7;
            this.currentButton.Text = "Current";
            this.currentButton.UseVisualStyleBackColor = true;
            this.currentButton.Click += new System.EventHandler(this.currentButton_Click);
            // 
            // savingsButton
            // 
            this.savingsButton.Location = new System.Drawing.Point(18, 125);
            this.savingsButton.Name = "savingsButton";
            this.savingsButton.Size = new System.Drawing.Size(100, 30);
            this.savingsButton.TabIndex = 6;
            this.savingsButton.Text = "Savings";
            this.savingsButton.UseVisualStyleBackColor = true;
            this.savingsButton.Click += new System.EventHandler(this.savingsButton_Click);
            // 
            // overdraftLabel
            // 
            this.overdraftLabel.AutoSize = true;
            this.overdraftLabel.Location = new System.Drawing.Point(31, 174);
            this.overdraftLabel.Name = "overdraftLabel";
            this.overdraftLabel.Size = new System.Drawing.Size(72, 13);
            this.overdraftLabel.TabIndex = 5;
            this.overdraftLabel.Text = "OverdraftLimit";
            this.overdraftLabel.Visible = false;
            // 
            // startBalance
            // 
            this.startBalance.AutoSize = true;
            this.startBalance.Location = new System.Drawing.Point(30, 96);
            this.startBalance.Name = "startBalance";
            this.startBalance.Size = new System.Drawing.Size(85, 13);
            this.startBalance.TabIndex = 4;
            this.startBalance.Text = "Starting Balance";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(30, 59);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(78, 13);
            this.accountLabel.TabIndex = 3;
            this.accountLabel.Text = "Account Name";
            // 
            // accountName
            // 
            this.accountName.Location = new System.Drawing.Point(124, 52);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(100, 20);
            this.accountName.TabIndex = 0;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(23, 75);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.accountNameLabel.TabIndex = 8;
            this.accountNameLabel.Text = "Account Name";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(149, 264);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(100, 30);
            this.withdrawButton.TabIndex = 7;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(27, 264);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(100, 30);
            this.depositButton.TabIndex = 6;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // changeOverdraftButton
            // 
            this.changeOverdraftButton.Location = new System.Drawing.Point(270, 264);
            this.changeOverdraftButton.Name = "changeOverdraftButton";
            this.changeOverdraftButton.Size = new System.Drawing.Size(100, 30);
            this.changeOverdraftButton.TabIndex = 3;
            this.changeOverdraftButton.Text = "Change Overdraft";
            this.changeOverdraftButton.UseVisualStyleBackColor = true;
            this.changeOverdraftButton.Click += new System.EventHandler(this.changeOverdraftButton_Click);
            // 
            // overdraftLimit
            // 
            this.overdraftLimit.AutoSize = true;
            this.overdraftLimit.Location = new System.Drawing.Point(273, 215);
            this.overdraftLimit.Name = "overdraftLimit";
            this.overdraftLimit.Size = new System.Drawing.Size(75, 13);
            this.overdraftLimit.TabIndex = 1;
            this.overdraftLimit.Text = "Overdraft Limit";
            // 
            // balanceAccount
            // 
            this.balanceAccount.AutoSize = true;
            this.balanceAccount.Location = new System.Drawing.Point(23, 127);
            this.balanceAccount.Name = "balanceAccount";
            this.balanceAccount.Size = new System.Drawing.Size(100, 13);
            this.balanceAccount.TabIndex = 0;
            this.balanceAccount.Text = "Balance of account";
            // 
            // accountSelectComboBox
            // 
            this.accountSelectComboBox.FormattingEnabled = true;
            this.accountSelectComboBox.ItemHeight = 13;
            this.accountSelectComboBox.Location = new System.Drawing.Point(26, 25);
            this.accountSelectComboBox.Name = "accountSelectComboBox";
            this.accountSelectComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountSelectComboBox.TabIndex = 10;
            this.accountSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.accountSelectComboBox_SelectedIndexChanged);
            // 
            // transactionResult
            // 
            this.transactionResult.AutoSize = true;
            this.transactionResult.Location = new System.Drawing.Point(24, 208);
            this.transactionResult.Name = "transactionResult";
            this.transactionResult.Size = new System.Drawing.Size(0, 13);
            this.transactionResult.TabIndex = 8;
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(27, 237);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(100, 20);
            this.depositBox.TabIndex = 11;
            this.depositBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositBox_KeyPress);
            // 
            // withdrawBox
            // 
            this.withdrawBox.Location = new System.Drawing.Point(149, 237);
            this.withdrawBox.Name = "withdrawBox";
            this.withdrawBox.Size = new System.Drawing.Size(100, 20);
            this.withdrawBox.TabIndex = 12;
            this.withdrawBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withdrawBox_KeyPress);
            // 
            // overdraftChange
            // 
            this.overdraftChange.Location = new System.Drawing.Point(270, 237);
            this.overdraftChange.Name = "overdraftChange";
            this.overdraftChange.Size = new System.Drawing.Size(100, 20);
            this.overdraftChange.TabIndex = 13;
            this.overdraftChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.overdraftChange_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 14;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(24, 148);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(0, 13);
            this.balanceLabel.TabIndex = 15;
            // 
            // addInterest
            // 
            this.addInterest.Location = new System.Drawing.Point(24, 25);
            this.addInterest.Name = "addInterest";
            this.addInterest.Size = new System.Drawing.Size(100, 30);
            this.addInterest.TabIndex = 1;
            this.addInterest.Text = "Add Interest";
            this.addInterest.UseVisualStyleBackColor = true;
            this.addInterest.Click += new System.EventHandler(this.addInterest_Click);
            // 
            // interestConfirmation
            // 
            this.interestConfirmation.AutoSize = true;
            this.interestConfirmation.Location = new System.Drawing.Point(21, 84);
            this.interestConfirmation.Name = "interestConfirmation";
            this.interestConfirmation.Size = new System.Drawing.Size(155, 13);
            this.interestConfirmation.TabIndex = 3;
            this.interestConfirmation.Text = "Interest Applied to all accounts.";
            this.interestConfirmation.Visible = false;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(917, 529);
            this.Controls.Add(this.bankPanel);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.bankButton);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BankForm";
            this.Text = "Banking Application";
            this.bankPanel.ResumeLayout(false);
            this.bankPanel.PerformLayout();
            this.accountViewPanel.ResumeLayout(false);
            this.accountViewPanel.PerformLayout();
            this.addAccountPanel.ResumeLayout(false);
            this.addAccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button bankButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Panel bankPanel;
        private System.Windows.Forms.Panel accountViewPanel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button changeOverdraftButton;
        private System.Windows.Forms.Label overdraftLimit;
        private System.Windows.Forms.Label balanceAccount;
        private System.Windows.Forms.Button addInterest;
        private System.Windows.Forms.Panel addAccountPanel;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Button savingsButton;
        private System.Windows.Forms.Label overdraftLabel;
        private System.Windows.Forms.Label startBalance;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.ComboBox accountSelectComboBox;
        private System.Windows.Forms.Label transactionResult;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Label creationSuccess;
        private System.Windows.Forms.TextBox accountBalance;
        private System.Windows.Forms.TextBox overdraftLimitNew;
        private System.Windows.Forms.TextBox overdraftChange;
        private System.Windows.Forms.TextBox withdrawBox;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label interestConfirmation;
    }
}

