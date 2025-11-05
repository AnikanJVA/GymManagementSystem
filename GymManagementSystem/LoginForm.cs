using classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GymManagementSystem
{
    public partial class LoginForm : Form
    {
        private Login login;
        private MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = BTN_login;
            this.Controls.Add(BTN_login);
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_password.Text) || string.IsNullOrWhiteSpace(TB_username.Text))
            {
                MessageBox.Show("Login Failed. Please Try Again.", "Failed");
            }
            else 
            {   
                login = new Login();
                if (login.AuthenticateUser(TB_username.Text.Trim(), TB_password.Text.Trim()))
                {
                    MessageBox.Show("Login Successful.", "Success");
                    string acctype = login.CurrentUser.AccType;
                    TB_username.Clear();
                    TB_password.Clear();
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
