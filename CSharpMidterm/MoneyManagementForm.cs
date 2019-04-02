using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortOrder = System.Windows.Forms.SortOrder;
using System.Data.SqlClient;

namespace CSharpMidterm
{
    public partial class MoneyManagementForm : Form
    {
        //public static string Username = ATMPIN.TransferID;
        //public static int PIN = ATMPIN.TransferPIN;
        public static int DoWhat = 0;
        public static int WithWhat = 0;
        public UserObject TheUser = new UserObject();

        public MoneyManagementForm(UserObject theuser)
        {
            TheUser = theuser;
            InitializeComponent();
        }

        private void MoneyManagementForm_Load(object sender, EventArgs e)
        {
            WelcomeBack.Text = "Welcome back, " + TheUser.UsernameObject;
            OutputTextbox.Visible = false;
            HowMuchMoneyLabel.Visible = false;
            MoneyMovingTextbox.Visible = false;
            ResetButton.Visible = false;
            YesButton.Visible = false;
            NoButton.Visible = false;
            GoAgane.Visible = false;
            OutputTextbox.Text = "";
            WelcomeBack.Visible = true;
            DoLabel.Visible = true;
            WithLabel.Visible = false;
            CheckBalancesButton.Visible = true;
            WithdrawCashButton.Visible = true;
            TransferMoneyButton.Visible = true;
            CheckingButton.Visible = false;
            SavingsButton.Visible = false;
            MoneyOKButton.Visible = false;
            OverdraftOKButton.Visible = false;
            SavingsButton.Text = "Savings";
            CheckingButton.Text = "Checking";
            PressOKToMoveOn.Visible = false;
            TheUser = SQLHelper.UserStatsReturn(TheUser.UsernameObject, TheUser.PINObject);
        }

        private void WelcomeBack_Click(object sender, EventArgs e)
        {

        }

        private void CheckingButton_Click(object sender, EventArgs e)
        {
            WithLabel.Visible = false;
            CheckingButton.Visible = false;
            SavingsButton.Visible = false;
            WithWhat = 2;
            CheckingObject CheckingStuff = new CheckingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
            // Check balance
            if (DoWhat == 1)
            {
                OutputTextbox.Text = "Your Checking balance is: $" + CheckingStuff.GetMoney().ToString();
                OutputTextbox.Visible = true;
                ResetButton.Visible = true;
            }
            // Withdraw money
            if (DoWhat == 2)
            {
                // if run out of money, take from checking
                // less interest than saving, but dont need to use
                OutputTextbox.Text = "";
                OutputTextbox.Visible = true;
                HowMuchMoneyLabel.Visible = true;
                MoneyMovingTextbox.Visible = true;
                MoneyOKButton.Visible = true;
            }
            // Transfer money
            if (DoWhat == 3)
            {

                HowMuchMoneyLabel.Visible = true;
                MoneyMovingTextbox.Visible = true;
                MoneyOKButton.Visible = true;
            }
        }

        private void SavingButton_Click(object sender, EventArgs e)
        {
            WithLabel.Visible = false;
            CheckingButton.Visible = false;
            SavingsButton.Visible = false;
            WithWhat = 1;
            SavingObject SavingStuff = new SavingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
            // Check balance
            if (DoWhat == 1)
            {
                OutputTextbox.Text = "Your Savings balance is: $" + SavingStuff.GetMoney().ToString();
                OutputTextbox.Visible = true;
                ResetButton.Visible = true;
            }
            // Withdraw money
            if (DoWhat == 2)
            {
                // more interest than checking
                // if checking runs out, get money from here
                OutputTextbox.Text = "";
                OutputTextbox.Visible = true;
                HowMuchMoneyLabel.Visible = true;
                MoneyMovingTextbox.Visible = true;
                MoneyOKButton.Visible = true;
            }
            // Transfer money
            if (DoWhat == 3)
            {

                HowMuchMoneyLabel.Visible = true;
                MoneyMovingTextbox.Visible = true;
                MoneyOKButton.Visible = true;
            }
        }

        private void CheckBalancesButton_Click(object sender, EventArgs e)
        {
            DoLabel.Visible = false;
            WithLabel.Visible = true;
            CheckBalancesButton.Visible = false;
            WithdrawCashButton.Visible = false;
            TransferMoneyButton.Visible = false;
            CheckingButton.Visible = true;
            SavingsButton.Visible = true;
            DoWhat = 1;
        }

        private void WithdrawCashButton_Click(object sender, EventArgs e)
        {
            DoLabel.Visible = false;
            WithLabel.Visible = true;
            CheckBalancesButton.Visible = false;
            WithdrawCashButton.Visible = false;
            TransferMoneyButton.Visible = false;
            CheckingButton.Visible = true;
            SavingsButton.Visible = true;
            DoWhat = 2;
        }

        private void TransferMoneyButton_Click(object sender, EventArgs e)
        {
            DoLabel.Visible = false;
            WithLabel.Visible = true;
            CheckBalancesButton.Visible = false;
            WithdrawCashButton.Visible = false;
            TransferMoneyButton.Visible = false;
            CheckingButton.Visible = true;
            SavingsButton.Visible = true;
            SavingsButton.Text = "Savings to Checking";
            CheckingButton.Text = "Checking to Savings";
            DoWhat = 3;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetButton.Visible = false;
            OutputTextbox.Visible = false;
            MoneyMovingTextbox.Visible = false;
            HowMuchMoneyLabel.Visible = false;
            WelcomeBack.Visible = false;
            GoAgane.Visible = true;
            YesButton.Visible = true;
            NoButton.Visible = true;
            PressOKToMoveOn.Visible = false;
            OutputTextbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            NoButton.Visible = false;
            YesButton.Visible = false;
            GoAgane.Visible = false;
            WelcomeBack.Visible = true;
            CheckBalancesButton.Visible = true;
            WithdrawCashButton.Visible = true;
            TransferMoneyButton.Visible = true;
            SavingsButton.Text = "Savings";
            CheckingButton.Text = "Checking";
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            // vvvvv SAVE CHANGES HERE vvvvv
            SQLHelper.SaveChanges(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);

            // ^^^^^ SAVE CHANGES HERE ^^^^^


            var form3 = new ATMPIN();
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
            this.Hide();


        }

        private void MoneyOKButton_Click(object sender, EventArgs e)
        {
            // Overdraft fee is going to be 30$
            MoneyOKButton.Visible = false;
            MoneyMovingTextbox.Visible = false;
            HowMuchMoneyLabel.Visible = false;
            // withdraw methods
            if (DoWhat == 2)
            {
                decimal TakeMoney = Convert.ToDecimal(MoneyMovingTextbox.Text);


                // Saving 
                if (WithWhat == 1)
                {
                    SavingObject SavingStuff = new SavingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
                    decimal NewTotal = SavingStuff.SavingObject - TakeMoney;


                    if (NewTotal < 0)
                    {
                        OutputTextbox.Text = "You overdrafted. You will still receive $" + TakeMoney + ", but you owe $" + Math.Abs(NewTotal) + " along with a $30.00 overdraft fee on a 12% interest";
                        // makes sure the object understands that this is the new total
                        SavingStuff.SavingObject = NewTotal - 30;
                        TheUser.SavingObject = SavingStuff.SavingObject;
                        ResetButton.Visible = true;
                    }
                    if (NewTotal > 0)
                    {
                        OutputTextbox.Text = "Money successfully withdrawn.";
                        SavingStuff.SavingObject = NewTotal;
                        TheUser.SavingObject = SavingStuff.SavingObject;
                        ResetButton.Visible = true;
                    }
                }
                // Checking
                if (WithWhat == 2)
                {
                    CheckingObject CheckingStuff = new CheckingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
                    decimal NewTotal = CheckingStuff.CheckingObject - TakeMoney;
                    if (NewTotal < 0)
                    {

                        // if savings can cover how much you went under
                        if (TheUser.SavingObject + NewTotal - 30 >= 0)
                        {
                            // if savings can cover how much you went under and overdraft fee
                            if (TheUser.SavingObject >= NewTotal + 30)
                            {
                                OutputTextbox.Text = "You overdrafted your Checking account because you only had $" + CheckingStuff.CheckingObject + " in your account. $"
                                    + Math.Abs(NewTotal) + " plus a $30.00 overdraft fee have been charged and paid for by your savings account. You will still recieve $" + TakeMoney + ".";
                                TheUser.SavingObject = TheUser.SavingObject + NewTotal - 30;
                                TheUser.CheckingObject = 0;
                                ResetButton.Visible = true;

                            }
                        }
                        else if (TheUser.SavingObject + NewTotal - 30 < 0)
                        {
                            decimal YouOwe = Math.Abs(TheUser.SavingObject + NewTotal + 30);
                            OutputTextbox.Text = "You overdrafted your Checking account because you only had $" + CheckingStuff.CheckingObject + " in your account. $"
                                    + Math.Abs(NewTotal) + " plus a $30.00 overdraft fee have been charged to your savings account, which could not cover it. Therefore you owe $" +
                                    YouOwe + " with a 12% interest. You will still recieve $" + TakeMoney + ".";
                            TheUser.SavingObject = TheUser.SavingObject + NewTotal + 30;
                            TheUser.CheckingObject = 0;
                            ResetButton.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Money successfully retrieved.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CheckingStuff.CheckingObject = NewTotal;
                        TheUser.CheckingObject = CheckingStuff.CheckingObject;
                        PressOKToMoveOn.Visible = true;
                        ResetButton.Visible = true;
                    }
                }

            }

            // transfer methods
            if (DoWhat == 3)
            {
                decimal TransferMoney = Convert.ToDecimal(MoneyMovingTextbox.Text);
                SavingObject SavingStuff = new SavingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
                CheckingObject CheckingStuff = new CheckingObject(TheUser.IDObject, TheUser.UsernameObject, TheUser.PINObject, TheUser.CheckingObject, TheUser.SavingObject);
                // saving to checking
                if (WithWhat == 1)
                {
                    if (TransferMoney > 0)
                    { 
                        if (SavingStuff.SavingObject >= TransferMoney)
                        {
                            MessageBox.Show("Money successfully moved.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SavingStuff.SavingObject = SavingStuff.SavingObject - TransferMoney;
                            TheUser.SavingObject = SavingStuff.SavingObject;
                            CheckingStuff.CheckingObject = CheckingStuff.CheckingObject + TransferMoney;
                            TheUser.CheckingObject = CheckingStuff.CheckingObject;
                            PressOKToMoveOn.Visible = true;
                            ResetButton.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("There is not enough funds in your Savings account to do this. Try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HowMuchMoneyLabel.Visible = true;
                            MoneyMovingTextbox.Visible = true;
                            MoneyOKButton.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot use negative numbers. Try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HowMuchMoneyLabel.Visible = true;
                        MoneyMovingTextbox.Visible = true;
                        MoneyOKButton.Visible = true;
                    }
                }

                // checking to saving
                if (WithWhat == 2)
                {
                    if (TransferMoney > 0)
                    {
                        if (CheckingStuff.CheckingObject >= TransferMoney)
                        {
                            MessageBox.Show("Money successfully moved.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CheckingStuff.CheckingObject = CheckingStuff.CheckingObject - TransferMoney;
                            TheUser.CheckingObject = CheckingStuff.CheckingObject;
                            SavingStuff.SavingObject = SavingStuff.SavingObject + TransferMoney;
                            TheUser.SavingObject = SavingStuff.SavingObject;
                            PressOKToMoveOn.Visible = true;
                            ResetButton.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("There is not enough funds in your Checking account to do this. Try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HowMuchMoneyLabel.Visible = true;
                            MoneyMovingTextbox.Visible = true;
                            MoneyOKButton.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot use negative numbers. Try again.", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HowMuchMoneyLabel.Visible = true;
                        MoneyMovingTextbox.Visible = true;
                        MoneyOKButton.Visible = true;
                    }
                }
            }
        }

        private void OverdraftOKButton_Click(object sender, EventArgs e)
        {

        }
    }
}
