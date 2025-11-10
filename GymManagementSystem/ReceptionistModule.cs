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
            mainForm.Sidebar_label_greetings.Text = "Welcome\nReceptionist!";
            mainForm.Sidebar_label_greetings.Padding = new System.Windows.Forms.Padding(
                mainForm.Sidebar_label_greetings.Padding.Left - 10,
                mainForm.Sidebar_label_greetings.Padding.Top,
                mainForm.Sidebar_label_greetings.Padding.Right,
                mainForm.Sidebar_label_greetings.Padding.Bottom
            );

            // buttons 
            Button[] buttons = {  mainForm.Sidebar_button1,
                                  mainForm.Sidebar_button2,
                                  mainForm.Sidebar_button3,
                                  mainForm.Sidebar_button4,
                                  mainForm.Sidebar_button5,
                                  mainForm.Sidebar_button6,
                                  mainForm.Sidebar_button7 };
            foreach (var button in buttons)
            {
                button.Visible = true;
            }
            mainForm.Sidebar_button1.Text = "Dashboard";
            mainForm.Sidebar_button2.Text = "Member Management";
            mainForm.Sidebar_button3.Text = "Check In Member";
            mainForm.Sidebar_button4.Text = "Coaching Sessions";
            mainForm.Sidebar_button5.Text = "Payment Transactions";
            mainForm.Sidebar_button6.Text = "Equipment Inventory";
            mainForm.Sidebar_button7.Text = "Damaged Equipment";

            //mainForm.button_logout.Margin = new System.Windows.Forms.Padding(
            //        mainForm.button_logout.Margin.Left,
            //        mainForm.button_logout.Margin.Top + 40,
            //        mainForm.button_logout.Margin.Right,
            //        mainForm.button_logout.Margin.Bottom
            //);
            // buttons

            // panel
            HidePanels(mainForm);
            mainForm.recep_panel1.Visible = true;
            // panel
        }

        public static void HidePanels(MainForm mainForm)
        {
            Panel[] panels = { mainForm.Admin_panel_dashboard,
                               mainForm.Admin_panel_staff,
                               mainForm.admin_panel4,
                               mainForm.admin_panel5,
                               mainForm.admin_panel6,
                               mainForm.admin_panel7,
                               mainForm.Admin_panel_ban,
                               mainForm.admin_panel9,
                               mainForm.admin_panel10,
                               mainForm.Admin_panel_equipment,
                               mainForm.Recep_panel_checkin,
                               mainForm.recep_panel1,
                               mainForm.recep_panel4,
                               mainForm.recep_panel5,
                               mainForm.recep_panel6,
                               mainForm.recep_panel7,
                               mainForm.Recep_panel_member };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.recep_panel1.Visible = true;
            // panel
        }

        public static void MemberMgmtButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.Recep_panel_member.Visible = true;
            // panel
        }

        public static void CheckInButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.Recep_panel_checkin.Visible = true;
            // panel
        }

        public static void CoachingButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.recep_panel4.Visible = true;
            // panel
        }

        public static void PaymentButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.recep_panel5.Visible = true;
            // panel
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.recep_panel6.Visible = true;
            // panel
        }

        public static void DamagedButtonClick(MainForm mainForm)
        {
            // panel
            HidePanels(mainForm);
            mainForm.recep_panel7.Visible = true;
            // panel
        }
    }
}
