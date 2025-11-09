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

            mainForm.Label_greetings.Text = "Welcome\nAdmin!";

            // buttons 
            Button[] buttons = {  mainForm.button1,
                                  mainForm.button2, 
                                  mainForm.button3,
                                  mainForm.button4,
                                  mainForm.button5, 
                                  mainForm.button6,
                                  mainForm.button7, 
                                  mainForm.button8 };
            foreach (var button in buttons)
            {
                button.Visible = true;
            }

            mainForm.button1.Text = "Dashboard";
            mainForm.button2.Text = "Account Management";
            mainForm.button3.Text = "Ban Member";
            mainForm.button4.Text = "Expenses Management";
            mainForm.button5.Text = "Sales Management";
            mainForm.button6.Text = "Payroll Managemnet";
            mainForm.button7.Text = "Cost Management";
            mainForm.button8.Text = "Equipment Inventory";

            // buttons 

            // panel
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel1.Visible = true;
            // panel
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel1.Visible = true;
            // panels
        }

        public static void AccountMgmtButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel2.Visible = true;
            // panels

            mainForm.dataGridView1_panel2.Visible = true;
            mainForm.dataGridView1_panel2.DataSource = Database.GetMembersTable();
        }

        public static void BanButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel3.Visible = true;
            // panels

            mainForm.dataGridView1_panel3.Visible = true;
            mainForm.dataGridView1_panel3.DataSource = Database.GetMembersTable();
        }

        public static void ExpensesButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel4.Visible = true;
            // panels
        }

        public static void SalesButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel6,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel5.Visible = true;
            // panels
        }
        public static void PayrollButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel7,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel6.Visible = true;
            // panels

            mainForm.dataGridView1_panel6.Visible = true;
            mainForm.dataGridView1_panel6.DataSource = Database.GetStaffTable();
        }

        public static void CostButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1,
                               mainForm.panel2,
                               mainForm.panel3,
                               mainForm.panel4,
                               mainForm.panel5,
                               mainForm.panel6,
                               mainForm.panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel7.Visible = true;
            // panels
        }

        public static void EquipmentButtonClick(MainForm mainForm)
        {
            // panels
            Panel[] panels = { mainForm.panel1, 
                               mainForm.panel2,
                               mainForm.panel3, 
                               mainForm.panel4, 
                               mainForm.panel5,    
                               mainForm.panel6,    
                               mainForm.panel7 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.panel8.Visible = true;
            // panels

            // textboxes and labels
            TextBox[] textBoxes = { mainForm.textBox1_panel8,
                                    mainForm.textBox2_panel8,
                                    mainForm.textBox3_panel8,
                                    mainForm.textBox4_panel8,
                                    mainForm.textBox5_panel8,
                                    mainForm.textBox6_panel8,
                                    mainForm.textBox7_panel8 };

            foreach (var panel in panels)
            {
                panel.Visible = false;
            }
            mainForm.textBox1_panel8.Enabled = false;

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
            mainForm.button1_panel8.Visible = true;
            mainForm.button1_panel8.Text = "Add";

            mainForm.button2_panel8.Visible = true;
            mainForm.button2_panel8.Text = "Update";
            // buttons


            // datagrid
            mainForm.dataGridView1_panel8.Visible = true;
            mainForm.dataGridView1_panel8.DataSource = Database.GetEquipmentsTable();
            // datagrid

        }

        
    }
}
