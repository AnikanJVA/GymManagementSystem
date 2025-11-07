using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    public class ReceptionistModule : IModules
    {
        public void RunModule(MainForm mainForm)
        {
            mainForm.Label_greetings.Text = "Welcome\nReceptionist!";
            mainForm.Label_greetings.Padding = new System.Windows.Forms.Padding(
                mainForm.Label_greetings.Padding.Left - 10,
                mainForm.Label_greetings.Padding.Top,
                mainForm.Label_greetings.Padding.Right,
                mainForm.Label_greetings.Padding.Bottom
            ); 

            mainForm.button1.Text = "Dashboard";
            mainForm.button1.Visible = true;

            mainForm.button2.Text = "Member Management";
            mainForm.button2.Visible = true;

            mainForm.button3.Text = "Check In Member";
            mainForm.button3.Visible = true;

            mainForm.button4.Text = "Coaching Sessions";
            mainForm.button4.Visible = true;

            mainForm.button5.Text = "Payment Transactions";
            mainForm.button5.Visible = true;

            mainForm.button6.Text = "Equipment Inventory";
            mainForm.button6.Visible = true;

            mainForm.button7.Text = "Damaged Equipment";
            mainForm.button7.Visible = true;

            mainForm.button_logout.Margin = new System.Windows.Forms.Padding(
                    mainForm.button_logout.Margin.Left,
                    mainForm.button_logout.Margin.Top + 40,
                    mainForm.button_logout.Margin.Right,
                    mainForm.button_logout.Margin.Bottom
            );

            mainForm.panel1.Visible = true;
            mainForm.label1.Text = "Dashboard";

            mainForm.panel2.Visible = false;
            mainForm.label2.Text = "Members";

            mainForm.panel3.Visible = false;
            mainForm.label3.Text = "Check in";

            mainForm.panel4.Visible = false;
            mainForm.label4.Text = "Coaching";

            mainForm.panel5.Visible = false;
            mainForm.label5.Text = "Payment";

            mainForm.panel6.Visible = false;
            mainForm.label6.Text = "equipment";

            mainForm.panel7.Visible = false;
            mainForm.label7.Text = "damaged";
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
        }

        public static void MemberMgmtButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = true;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
        }

        public static void CheckInButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = true;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
        }

        public static void CoachingButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = true;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
        }

        public static void PaymentButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = true;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = false;
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = true;
            mainForm.panel7.Visible = false;
        }

        public static void DamagedButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = false;
            mainForm.panel3.Visible = false;
            mainForm.panel4.Visible = false;
            mainForm.panel5.Visible = false;
            mainForm.panel6.Visible = false;
            mainForm.panel7.Visible = true;
        }
    }
}
