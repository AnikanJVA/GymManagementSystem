using ClassLibrary;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public class AdminModule : IModules
    {
        public void RunModule(MainForm mainForm)
        {

            mainForm.Sidebar_label_greetings.Text = "Welcome\nAdmin!";

            // buttons 
            Button[] buttons = {  mainForm.Sidebar_button1,
                                  mainForm.Sidebar_button2, 
                                  mainForm.Sidebar_button3,
                                  mainForm.Sidebar_button4,
                                  mainForm.Sidebar_button5, 
                                  mainForm.Sidebar_button6,
                                  mainForm.Sidebar_button7, 
                                  mainForm.Sidebar_button8 };
            foreach (var button in buttons)
            {
                button.Visible = true;
            }

            mainForm.Sidebar_button1.Text = "Dashboard";
            mainForm.Sidebar_button2.Text = "Staff Management";
            mainForm.Sidebar_button3.Text = "Member Management";
            mainForm.Sidebar_button4.Text = "View Sales Report";
            mainForm.Sidebar_button5.Text = "Price Management";
            mainForm.Sidebar_button6.Text = "Equipment Inventory";
            mainForm.Sidebar_button7.Text = "User Accounts Management";
            mainForm.Sidebar_button8.Text = "Coaching Sessions";

            // buttons 

            // panel
            HidePanels(mainForm);
            mainForm.Admin_panel_dashboard.Visible = true;
            // panel
        }

        public static void HidePanels(MainForm mainForm)
        {
            Panel[] panels = { mainForm.Admin_panel_dashboard,
                               mainForm.Admin_panel_staffs,
                               mainForm.Admin_panel_sales,
                               mainForm.Admin_panel_price,
                               mainForm.Admin_panel_equipment,
                               mainForm.Admin_panel_users,
                               mainForm.Admin_panel_coaching,
                               mainForm.Recep_panel_dashboard,
                               mainForm.Recep_panel_members,
                               mainForm.Recep_panel_checkin,
                               mainForm.Recep_panel_coaching,
                               mainForm.Recep_panel_biling,
                               mainForm.Recep_panel_damage };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_dashboard.Visible = true;
            // panels
        }

        public static void StafftMgmtButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_staffs.Visible = true;
            // panels

            // datagridviews
            mainForm.Staff_dataGridView_staff.DataSource = Database.GetStaffsTable();
            // datagridviews
        }

        public static void SalesButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_sales.Visible = true;
            // panels
        }
     
        public static void PriceButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_price.Visible = true;
            // panels
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_equipment.Visible = true;
            // panels

            // datagrid
            mainForm.Equipments_dataGridView_equipments.DataSource = Database.GetEquipmentsTable();
            // datagrid

        }

        public static void UserAccMgmtButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_users.Visible = true;
            // panels

            // datagrid
            mainForm.Users_dataGridView_users.DataSource = Database.GetUsersTable();
            // datagrid
        }

        public static void CoachingSessionsButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_coaching.Visible = true;
            // panels
        }
    }
}
