using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMidterm
{
    public partial class ATMPIN : Form
    {
        public static string TransferID = "";
        public static int TransferPIN = 0;
        public ATMPIN()
        {
            InitializeComponent();
        }

        private void ATMPIN_Load(object sender, EventArgs e)
        {
            OutputTextbox.Text = "Please input your Username and PIN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameText.Text))
            {
                OutputTextbox.Text = "Please input your Username";
            }
            else if (string.IsNullOrEmpty(PINText.Text))
            {
                OutputTextbox.Text = "Please input your PIN";
            }
            else
            {
                UserObject userObject = new UserObject();
                string UsernameTesting = UsernameText.Text;
                int PINTesting = Convert.ToInt32(PINText.Text);
                string Worked = SQLHelper.TryInput(UsernameTesting, PINTesting);
                OutputTextbox.Text = Worked;
                if (Worked == "Successful login. Welcome back " + UsernameTesting)
                {
                    userObject.UsernameObject = UsernameTesting;
                    userObject.PINObject = PINTesting;
                    var form2 = new MoneyManagementForm(userObject);
                    form2.FormClosed += (s, args) => this.Close();
                    form2.Show();
                    this.Hide();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
