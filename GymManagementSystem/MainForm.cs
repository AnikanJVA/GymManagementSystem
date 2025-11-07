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

        private void button3_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.BanButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.CheckInButtonClick(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.ExpensesButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.CoachingButtonClick(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.SalesButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.PaymentButtonClick(this);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.PayrollButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.EquipmentButtonClick(this);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.CostButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.DamagedButtonClick(this);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminModule.EquipmentButtonClick(this);
        }
    }
}
