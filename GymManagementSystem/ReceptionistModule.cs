using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // buttons 
            Button[] buttons = {  mainForm.button1,
                                  mainForm.button2,
                                  mainForm.button3,
                                  mainForm.button4,
                                  mainForm.button5,
                                  mainForm.button6,
                                  mainForm.button7 };
            foreach (var button in buttons)
            {
                button.Visible = true;
            }
            mainForm.button1.Text = "Dashboard";
            mainForm.button2.Text = "Member Management";
            mainForm.button3.Text = "Check In Member";
            mainForm.button4.Text = "Coaching Sessions";
            mainForm.button5.Text = "Payment Transactions";
            mainForm.button6.Text = "Equipment Inventory";
            mainForm.button7.Text = "Damaged Equipment";

            mainForm.button_logout.Margin = new System.Windows.Forms.Padding(
                    mainForm.button_logout.Margin.Left,
                    mainForm.button_logout.Margin.Top + 40,
                    mainForm.button_logout.Margin.Right,
                    mainForm.button_logout.Margin.Bottom
            );
            // buttons

            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel1.Visible = true;
            // panel
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel1.Visible = true;
            // panel
        }

        public static void MemberMgmtButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel2.Visible = true;
            // panel
        }

        public static void CheckInButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel3.Visible = true;
            // panel
        }

        public static void CoachingButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel4.Visible = true;
            // panel
        }

        public static void PaymentButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel6,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel5.Visible = true;
            // panel
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel6.Visible = true;
            // panel
        }

        public static void DamagedButtonClick(MainForm mainForm)
        {
            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel7.Visible = true;
            // panel
        }
    }
}
