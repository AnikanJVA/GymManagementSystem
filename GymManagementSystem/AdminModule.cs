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
                                  mainForm.Sidebar_button8, 
                                  mainForm.Sidebar_button9, 
                                  mainForm.Sidebar_button10 };
            foreach (var button in buttons)
            {
                button.Visible = true;
            }

            mainForm.Sidebar_button1.Text = "Dashboard";
            mainForm.Sidebar_button2.Text = "Staff Management";
            mainForm.Sidebar_button3.Text = "Member Management";
            mainForm.Sidebar_button4.Text = "Expenses Management";
            mainForm.Sidebar_button5.Text = "Sales";
            mainForm.Sidebar_button6.Text = "Payroll Managemnet";
            mainForm.Sidebar_button7.Text = "Price Management";
            mainForm.Sidebar_button8.Text = "Equipment Inventory";
            mainForm.Sidebar_button9.Text = "User Accounts Management";
            mainForm.Sidebar_button10.Text = "Coaching Sessions";

            // buttons 

            // panel
            HidePanels(mainForm);
            mainForm.Admin_panel_dashboard.Visible = true;
            // panel
        }

        public static void HidePanels(MainForm mainForm)
        {
            Panel[] panels = { mainForm.Admin_panel_dashboard,
                               mainForm.Admin_panel_staff,
                               mainForm.Admin_panel_ban,
                               mainForm.admin_panel4,
                               mainForm.admin_panel5,
                               mainForm.admin_panel6,
                               mainForm.admin_panel7,
                               mainForm.Admin_panel_equipment,
                               mainForm.admin_panel9,
                               mainForm.recep_panel1,
                               mainForm.Recep_panel_member,
                               mainForm.Recep_panel_checkin,
                               mainForm.recep_panel4,
                               mainForm.recep_panel5,
                               mainForm.recep_panel6,
                               mainForm.recep_panel7,
                               mainForm.admin_panel10 };

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
            mainForm.Admin_panel_staff.Visible = true;
            // panels

            // datagridviews
            mainForm.dataGridView1_panel2.DataSource = Database.GetStaffsTable();
            // datagridviews
        }

        public static void BanButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_ban.Visible = true;
            // panels

            mainForm.dataGridView1_panel3.DataSource = Database.GetMembersTable();
        }

        public static void ExpensesButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel4.Visible = true;
            // panels
        }

        public static void SalesButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel5.Visible = true;
            // panels
        }
        public static void PayrollButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel6.Visible = true;
            // panels

            mainForm.dataGridView1_panel6.DataSource = Database.GetStaffsTable();
        }

        public static void CostButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel7.Visible = true;
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
            mainForm.admin_panel9.Visible = true;
            // panels

            // datagrid
            mainForm.dataGridView1_panel9.DataSource = Database.GetUsersTable();
            // datagrid
        }

        public static void CoachingSessionsButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel10.Visible = true;
            // panels
        }
    }
}
