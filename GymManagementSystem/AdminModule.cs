using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    public class AdminModule : IModules
    {
        public void RunModule(MainForm mainForm)
        {
            mainForm.Label_greetings.Text = "Welcome\nAdmin!";

            mainForm.button1.Text = "Dashboard";
            mainForm.button1.Visible = true;
            
            mainForm.button2.Text = "Account Management";
            mainForm.button2.Visible = true;

            mainForm.button3.Text = "Ban Member";
            mainForm.button3.Visible = true;

            mainForm.button4.Text = "Expenses Management";
            mainForm.button4.Visible = true;

            mainForm.button5.Text = "Sales Management";
            mainForm.button5.Visible = true;

            mainForm.button6.Text = "Payroll Managemnet";
            mainForm.button6.Visible = true;

            mainForm.button7.Text = "Cost Management";
            mainForm.button7.Visible = true;

            mainForm.button8.Text = "Equipment Inventory";
            mainForm.button8.Visible = true;

            mainForm.panel1.Visible = true;
            mainForm.label1.Text = "Dashboard";

            mainForm.panel2.Visible = false;
            mainForm.label2.Text = "Accounts";

            mainForm.panel3.Visible = false;
            mainForm.label3.Text = "Ban";

            mainForm.panel4.Visible = false;
            mainForm.label4.Text = "Expenses";

            mainForm.panel5.Visible = false;
            mainForm.label5.Text = "Sales";

            mainForm.panel6.Visible = false;
            mainForm.label6.Text = "Payroll";

            mainForm.panel7.Visible = false;
            mainForm.label7.Text = "Cost";

            mainForm.panel8.Visible = false;
            mainForm.label8.Text = "Inventory";
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = true;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }

        public static void AccountMgmtButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = true;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }

        public static void BanButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = true;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }

        public static void ExpensesButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = true;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }

        public static void SalesButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = true;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }
        public static void PayrollButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = true;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = false;
        }

        public static void CostButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = true;
            mainForm.panel8.Visible = false;
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
            mainForm.panel8.Visible = true;
        }
    }
}
