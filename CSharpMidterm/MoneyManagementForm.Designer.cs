namespace CSharpMidterm
{
    partial class MoneyManagementForm
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
            this.WelcomeBack = new System.Windows.Forms.Label();
            this.CheckingButton = new System.Windows.Forms.Button();
            this.SavingsButton = new System.Windows.Forms.Button();
            this.CheckBalancesButton = new System.Windows.Forms.Button();
            this.WithdrawCashButton = new System.Windows.Forms.Button();
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.DoLabel = new System.Windows.Forms.Label();
            this.WithLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.MoneyMovingTextbox = new System.Windows.Forms.TextBox();
            this.HowMuchMoneyLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.GoAgane = new System.Windows.Forms.Label();
            this.MoneyOKButton = new System.Windows.Forms.Button();
            this.OverdraftOKButton = new System.Windows.Forms.Button();
            this.PressOKToMoveOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeBack
            // 
            this.WelcomeBack.AutoSize = true;
            this.WelcomeBack.Location = new System.Drawing.Point(299, 9);
            this.WelcomeBack.Name = "WelcomeBack";
            this.WelcomeBack.Size = new System.Drawing.Size(143, 13);
            this.WelcomeBack.TabIndex = 0;
            this.WelcomeBack.Text = "Welcome Back, _________.";
            // 
            // CheckingButton
            // 
            this.CheckingButton.Location = new System.Drawing.Point(594, 216);
            this.CheckingButton.Name = "CheckingButton";
            this.CheckingButton.Size = new System.Drawing.Size(194, 84);
            this.CheckingButton.TabIndex = 1;
            this.CheckingButton.Text = "Checking";
            this.CheckingButton.UseVisualStyleBackColor = true;
            this.CheckingButton.Click += new System.EventHandler(this.CheckingButton_Click);
            // 
            // SavingsButton
            // 
            this.SavingsButton.Location = new System.Drawing.Point(594, 126);
            this.SavingsButton.Name = "SavingsButton";
            this.SavingsButton.Size = new System.Drawing.Size(194, 84);
            this.SavingsButton.TabIndex = 2;
            this.SavingsButton.Text = "Savings";
            this.SavingsButton.UseVisualStyleBackColor = true;
            this.SavingsButton.Click += new System.EventHandler(this.SavingButton_Click);
            // 
            // CheckBalancesButton
            // 
            this.CheckBalancesButton.Location = new System.Drawing.Point(12, 79);
            this.CheckBalancesButton.Name = "CheckBalancesButton";
            this.CheckBalancesButton.Size = new System.Drawing.Size(194, 84);
            this.CheckBalancesButton.TabIndex = 3;
            this.CheckBalancesButton.Text = "Check Balances";
            this.CheckBalancesButton.UseVisualStyleBackColor = true;
            this.CheckBalancesButton.Click += new System.EventHandler(this.CheckBalancesButton_Click);
            // 
            // WithdrawCashButton
            // 
            this.WithdrawCashButton.Location = new System.Drawing.Point(12, 169);
            this.WithdrawCashButton.Name = "WithdrawCashButton";
            this.WithdrawCashButton.Size = new System.Drawing.Size(194, 84);
            this.WithdrawCashButton.TabIndex = 4;
            this.WithdrawCashButton.Text = "Withdraw Cash";
            this.WithdrawCashButton.UseVisualStyleBackColor = true;
            this.WithdrawCashButton.Click += new System.EventHandler(this.WithdrawCashButton_Click);
            // 
            // TransferMoneyButton
            // 
            this.TransferMoneyButton.Location = new System.Drawing.Point(12, 259);
            this.TransferMoneyButton.Name = "TransferMoneyButton";
            this.TransferMoneyButton.Size = new System.Drawing.Size(194, 84);
            this.TransferMoneyButton.TabIndex = 5;
            this.TransferMoneyButton.Text = "Transfer Money";
            this.TransferMoneyButton.UseVisualStyleBackColor = true;
            this.TransferMoneyButton.Click += new System.EventHandler(this.TransferMoneyButton_Click);
            // 
            // DoLabel
            // 
            this.DoLabel.AutoSize = true;
            this.DoLabel.Location = new System.Drawing.Point(89, 63);
            this.DoLabel.Name = "DoLabel";
            this.DoLabel.Size = new System.Drawing.Size(24, 13);
            this.DoLabel.TabIndex = 6;
            this.DoLabel.Text = "Do:";
            // 
            // WithLabel
            // 
            this.WithLabel.AutoSize = true;
            this.WithLabel.Location = new System.Drawing.Point(672, 63);
            this.WithLabel.Name = "WithLabel";
            this.WithLabel.Size = new System.Drawing.Size(32, 13);
            this.WithLabel.TabIndex = 7;
            this.WithLabel.Text = "With:";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(277, 63);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(223, 110);
            this.OutputTextbox.TabIndex = 8;
            // 
            // MoneyMovingTextbox
            // 
            this.MoneyMovingTextbox.Location = new System.Drawing.Point(327, 216);
            this.MoneyMovingTextbox.Multiline = true;
            this.MoneyMovingTextbox.Name = "MoneyMovingTextbox";
            this.MoneyMovingTextbox.Size = new System.Drawing.Size(115, 37);
            this.MoneyMovingTextbox.TabIndex = 9;
            // 
            // HowMuchMoneyLabel
            // 
            this.HowMuchMoneyLabel.AutoSize = true;
            this.HowMuchMoneyLabel.Location = new System.Drawing.Point(333, 197);
            this.HowMuchMoneyLabel.Name = "HowMuchMoneyLabel";
            this.HowMuchMoneyLabel.Size = new System.Drawing.Size(100, 13);
            this.HowMuchMoneyLabel.TabIndex = 10;
            this.HowMuchMoneyLabel.Text = "How Much Money?";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(347, 259);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "OK";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(463, 305);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 13;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(247, 305);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 14;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // GoAgane
            // 
            this.GoAgane.AutoSize = true;
            this.GoAgane.Location = new System.Drawing.Point(274, 285);
            this.GoAgane.Name = "GoAgane";
            this.GoAgane.Size = new System.Drawing.Size(230, 13);
            this.GoAgane.TabIndex = 15;
            this.GoAgane.Text = "Would You Like to Make Another Transaction?";
            // 
            // MoneyOKButton
            // 
            this.MoneyOKButton.Location = new System.Drawing.Point(347, 259);
            this.MoneyOKButton.Name = "MoneyOKButton";
            this.MoneyOKButton.Size = new System.Drawing.Size(75, 23);
            this.MoneyOKButton.TabIndex = 16;
            this.MoneyOKButton.Text = "OK";
            this.MoneyOKButton.UseVisualStyleBackColor = true;
            this.MoneyOKButton.Click += new System.EventHandler(this.MoneyOKButton_Click);
            // 
            // OverdraftOKButton
            // 
            this.OverdraftOKButton.Location = new System.Drawing.Point(347, 179);
            this.OverdraftOKButton.Name = "OverdraftOKButton";
            this.OverdraftOKButton.Size = new System.Drawing.Size(75, 23);
            this.OverdraftOKButton.TabIndex = 17;
            this.OverdraftOKButton.Text = "OK";
            this.OverdraftOKButton.UseVisualStyleBackColor = true;
            this.OverdraftOKButton.Click += new System.EventHandler(this.OverdraftOKButton_Click);
            // 
            // PressOKToMoveOn
            // 
            this.PressOKToMoveOn.AutoSize = true;
            this.PressOKToMoveOn.Location = new System.Drawing.Point(333, 240);
            this.PressOKToMoveOn.Name = "PressOKToMoveOn";
            this.PressOKToMoveOn.Size = new System.Drawing.Size(107, 13);
            this.PressOKToMoveOn.TabIndex = 18;
            this.PressOKToMoveOn.Text = "Press OK to move on";
            // 
            // MoneyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PressOKToMoveOn);
            this.Controls.Add(this.OverdraftOKButton);
            this.Controls.Add(this.MoneyOKButton);
            this.Controls.Add(this.GoAgane);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HowMuchMoneyLabel);
            this.Controls.Add(this.MoneyMovingTextbox);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.WithLabel);
            this.Controls.Add(this.DoLabel);
            this.Controls.Add(this.TransferMoneyButton);
            this.Controls.Add(this.WithdrawCashButton);
            this.Controls.Add(this.CheckBalancesButton);
            this.Controls.Add(this.SavingsButton);
            this.Controls.Add(this.CheckingButton);
            this.Controls.Add(this.WelcomeBack);
            this.Name = "MoneyManagementForm";
            this.Text = "MoneyManagementForm";
            this.Load += new System.EventHandler(this.MoneyManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeBack;
        private System.Windows.Forms.Button CheckingButton;
        private System.Windows.Forms.Button SavingsButton;
        private System.Windows.Forms.Button CheckBalancesButton;
        private System.Windows.Forms.Button WithdrawCashButton;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.Label DoLabel;
        private System.Windows.Forms.Label WithLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.TextBox MoneyMovingTextbox;
        private System.Windows.Forms.Label HowMuchMoneyLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label GoAgane;
        private System.Windows.Forms.Button MoneyOKButton;
        private System.Windows.Forms.Button OverdraftOKButton;
        private System.Windows.Forms.Label PressOKToMoveOn;
    }
}