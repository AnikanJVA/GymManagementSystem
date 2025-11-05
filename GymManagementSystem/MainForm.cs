using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classes;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        public string accType;

        public MainForm(string accType)
        {
            InitializeComponent();
            this.accType = accType;
            var view = Modules.CreateView(accType);
            view.RunModule(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(accType == "ADMIN")
            {
                AdminModule.DashboardButtonClick(this);
            }
            else if(accType == "COACH")
            {
                CoachModule.DashboardButtonClick(this);
            }
            else if(accType == "RECEPTIONIST")
            {
                ReceptionistModule.DashboardButtonClick(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.AccountMgmtButtonClick(this);
            }
            else if (accType == "COACH")
            {
                CoachModule.SessionsButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.MemberMgmtButtonClick(this);
            }
        }
    }
}
