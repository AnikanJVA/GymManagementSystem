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
            mainForm.Sidebar_button3.Text = "Ban Member";
            mainForm.Sidebar_button4.Text = "Expenses Management";
            mainForm.Sidebar_button5.Text = "Sales Management";
            mainForm.Sidebar_button6.Text = "Payroll Managemnet";
            mainForm.Sidebar_button7.Text = "Cost Management";
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

            // textboxes, labels, datetime picker,  combobox 
            TextBox[] textBoxes = { mainForm.textBox1_panel2,
                                    mainForm.textBox2_panel2,
                                    mainForm.textBox3_panel2,
                                    mainForm.textBox4_panel2,
                                    mainForm.textBox5_panel2,
                                    mainForm.textBox6_panel2,
                                    mainForm.textBox7_panel2 };
            foreach (var textBox in textBoxes)
            {
                textBox.Visible = true;
            }

            mainForm.textBox6_panel2.Multiline = true;
            mainForm.textBox6_panel2.WordWrap = true;
            mainForm.textBox6_panel2.Height = 59;

            mainForm.textBox7_panel2.ReadOnly = true;

            Label[] labels = { mainForm.label1_panel2,
                               mainForm.label2_panel2,
                               mainForm.label3_panel2,
                               mainForm.label4_panel2,
                               mainForm.label5_panel2,
                               mainForm.label6_panel2,
                               mainForm.label7_panel2,
                               mainForm.label8_panel2,
                               mainForm.label9_panel2,
                               mainForm.label10_panel2,
                               mainForm.label11_panel2,
                               mainForm.label12_panel2,
                               mainForm.label12_panel2 };
            foreach (var label in labels)
            {
                label.Visible = true;
            }

            mainForm.label1_panel2.Text = "First Name";
            mainForm.label2_panel2.Text = "Middle Name";
            mainForm.label3_panel2.Text = "Last Name";
            mainForm.label4_panel2.Text = "Date Of Birth";
            mainForm.label5_panel2.Text = "Sex";
            mainForm.label6_panel2.Text = "Contact No.";
            mainForm.label7_panel2.Text = "Email";
            mainForm.label8_panel2.Text = "Address";
            mainForm.label9_panel2.Text = "Schedule";
            mainForm.label10_panel2.Text = "Position";
            mainForm.label11_panel2.Text = "Status";
            mainForm.label12_panel2.Text = "StaffID";

            mainForm.dateTimePicker1_panel2.Visible = true;

            mainForm.comboBox1_panel2.Visible = true;
            mainForm.comboBox2_panel2.Visible = true;
            // textboxes, labels, datetime picker,  combobox 

            // radio buttons
            mainForm.radioButton1_panel2.Visible = true;
            mainForm.radioButton1_panel2.Text = "Male";

            mainForm.radioButton2_panel2.Visible = true;
            mainForm.radioButton2_panel2.Text = "Female";
            // radio buttons

            //checkboxes
            CheckBox[] checkBoxes = { mainForm.checkBox1_panel2,
                                      mainForm.checkBox2_panel2,
                                      mainForm.checkBox3_panel2,
                                      mainForm.checkBox4_panel2,
                                      mainForm.checkBox5_panel2,
                                      mainForm.checkBox6_panel2,
                                      mainForm.checkBox7_panel2 };
            foreach (var checkBox in checkBoxes) 
            {
                checkBox.Visible = true;
            }

            //checkboxes

            // buttons 
            mainForm.Staff_button_add.Visible = true;
            mainForm.Staff_button_add.Text = "Add Staff";

            mainForm.Staff_button_delete.Visible = true;
            mainForm.Staff_button_delete.Text = "Delete Staff";

            mainForm.Staff_button_update.Visible = true;
            mainForm.Staff_button_update.Text = "Update Staff";
            // buttons 

            // datagridviews
            mainForm.dataGridView1_panel2.Visible = true;
            mainForm.dataGridView1_panel2.DataSource = Database.GetStaffsTable();
            // datagridviews
        }

        public static void BanButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.Admin_panel_ban.Visible = true;
            // panels

            mainForm.dataGridView1_panel3.Visible = true;
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

            mainForm.dataGridView1_panel6.Visible = true;
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

            // textboxes and labels
            TextBox[] textBoxes = { mainForm.Equipments_textBox_id,
                                    mainForm.Equipments_textBox_name,   
                                    mainForm.Equipments_textBox_brand,
                                    mainForm.Equipments_textBox_model,
                                    mainForm.Equipments_textBox_cost,
                                    mainForm.Equipments_textBox_quantity };

            foreach (var textbox in textBoxes)
            {
                textbox.Visible = true;
            }
            mainForm.Equipments_textBox_id.ReadOnly = true;

            mainForm.label1_panel8.Text = "Equipment ID";
            mainForm.label2_panel8.Text = "Equipment Name";
            mainForm.label3_panel8.Text = "Brand";
            mainForm.label4_panel8.Text = "Model";
            mainForm.label5_panel8.Text = "Category";
            mainForm.label6_panel8.Text = "Cost";
            mainForm.label7_panel8.Text = "Quantity";
            mainForm.label8_panel8.Text = "Condition";
            // textboxes and labels

            // buttons
            mainForm.Equipments_button_add.Visible = true;
            mainForm.Equipments_button_add.Text = "Add Equipment";

            mainForm.Equipments_button_update.Visible = true;
            mainForm.Equipments_button_update.Text = "Update Equipment";
            // buttons


            // datagrid
            mainForm.Equipments_dataGridView_equipments.Visible = true;
            mainForm.Equipments_dataGridView_equipments.DataSource = Database.GetEquipmentsTable();
            // datagrid

        }

        public static void UserAccMgmtButtonClick(MainForm mainForm)
        {
            // panels
            HidePanels(mainForm);
            mainForm.admin_panel9.Visible = true;
            // panels

            // textboxes, labels, combobox
            TextBox[] textBoxes = { mainForm.textBox1_panel9,
                                    mainForm.textBox2_panel9,
                                    mainForm.textBox3_panel9 };

            foreach (var textbox in textBoxes)
            {
                textbox.Visible = true;
            }
            mainForm.textBox3_panel9.ReadOnly = true;

            Label[] labels = { mainForm.label1_panel9,
                               mainForm.label2_panel9,
                               mainForm.label3_panel9,
                               mainForm.label4_panel9,
                               mainForm.label5_panel9  };
            foreach (var label in labels)
            {
                label.Visible = true;
            }

            mainForm.label1_panel9.Text = "Username";
            mainForm.label2_panel9.Text = "Password";
            mainForm.label3_panel9.Text = "Account Type";
            mainForm.label4_panel9.Text = "Status";
            mainForm.label5_panel9.Text = "UserID";

            mainForm.comboBox1_panel9.Visible = true;
            mainForm.comboBox2_panel9.Visible = true;
            // textboxes, labels, combobox

            // buttons
            mainForm.button1_panel9.Visible = true;
            mainForm.button1_panel9.Text = "Add User";

            mainForm.button2_panel9.Visible = true;
            mainForm.button2_panel9.Text = "Update User";
            // buttons


            // datagrid
            mainForm.dataGridView1_panel9.Visible = true;
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
