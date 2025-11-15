using ClassLibrary;
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
            mainForm.Sidebar_button5.Text = "Billing";
            mainForm.Sidebar_button6.Text = "Equipment Inventory";
            mainForm.Sidebar_button7.Text = "Report Damaged Equipment";

            // buttons

            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_dashboard.Visible = true;
            // panel
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_dashboard.Visible = true;
            // panel
        }

        public static void MemberMgmtButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_members.Visible = true;
            // panel

            // datagrid
            mainForm.Recep_members_dataGridView_members.DataSource = Database.GetMembersTable();
            // datagrid

            // combobox, datetime picker
            mainForm.Recep_members_comboBox_plan.Enabled = false;
            mainForm.Recep_members_dateTimePicker_membershipDate.Enabled = false;
            // combobox, datetime picker
        }

        public static void CheckInButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_checkin.Visible = true;
            // panel
        }

        public static void CoachingButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_coaching.Visible = true;
            // panel
        }

        public static void PaymentButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_biling.Visible = true;
            // panel
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Admin_panel_equipment.Visible = true;
            // panel
            
            // datagrid
            mainForm.Equipments_dataGridView_equipments.DataSource = Database.GetEquipmentsTable();
            // datagrid

            // buttons
            mainForm.Equipments_button_add.Visible = false;
            mainForm.Equipments_button_update.Visible = false;
            mainForm.Equipments_button_clear.Visible = false;
            // buttons

            // textbox, combobox
            foreach(Control control in mainForm.panel1.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.ReadOnly = true;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                }
            }
            // textbox, combobox
        }

        public static void DamagedButtonClick(MainForm mainForm)
        {
            // panel
            AdminModule.HidePanels(mainForm);
            mainForm.Recep_panel_damage.Visible = true;
            // panel

            // datagrid
            mainForm.Damaged_dataGridView_equipments.DataSource = Database.GetEquipmentsTable();
            // datagrid

        }
    }
}
