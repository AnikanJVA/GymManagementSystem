using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class LoginForm : Form
    {
        private Login login;
        private MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = Button_login;
            this.Controls.Add(Button_login);
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_password.Text) || string.IsNullOrWhiteSpace(TextBox_username.Text))
            {
                MessageBox.Show("Login Failed. Please Try Again.", "Failed");
            }
            else 
            {   
                login = new Login();
                if (login.AuthenticateUser(TextBox_username.Text.Trim(), TextBox_password.Text.Trim()))
                {
                    MessageBox.Show("Login Successful.", "Success");
                    string acctype = login.CurrentUser.AccType;
                    TextBox_username.Clear();
                    TextBox_password.Clear();
                    mainForm = new MainForm(acctype);
                    mainForm.Show();
                    FormProvider.Login.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed. Please Try Again.", "Failed");
                }
            }
        }
    }
}
