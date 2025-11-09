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
            mainForm.button2.Text = "Staff Management";
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

        public static void StafftMgmtButtonClick(MainForm mainForm)
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

            // textboxes, labels, datetime picker,  combobox 
            TextBox[] textBoxes = { mainForm.textBox1_panel2,
                                    mainForm.textBox2_panel2,
                                    mainForm.textBox3_panel2,
                                    mainForm.textBox4_panel2,
                                    mainForm.textBox5_panel2,
                                    mainForm.textBox6_panel2,
                                    mainForm.textBox7_panel2,
                                    mainForm.textBox8_panel2 };
            foreach (var textBox in textBoxes)
            {
                textBox.Visible = true;
            }

            mainForm.textBox8_panel2.Multiline = true;
            mainForm.textBox8_panel2.WordWrap = true;
            mainForm.textBox8_panel2.Height = 59;

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
                               mainForm.label13_panel2 };
            foreach (var label in labels)
            {
                label.Visible = true;
            }

            mainForm.label1_panel2.Text = "Username";
            mainForm.label2_panel2.Text = "Password";
            mainForm.label3_panel2.Text = "Account Type";
            mainForm.label4_panel2.Text = "First Name";
            mainForm.label5_panel2.Text = "Middle Name";
            mainForm.label6_panel2.Text = "Last Name";
            mainForm.label7_panel2.Text = "Date Of Birth";
            mainForm.label8_panel2.Text = "Sex";
            mainForm.label9_panel2.Text = "Contact No.";
            mainForm.label10_panel2.Text = "Email";
            mainForm.label11_panel2.Text = "Address";
            mainForm.label12_panel2.Text = "Schedule";
            mainForm.label13_panel2.Text = "Position";

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
            mainForm.button1_panel2.Visible = true;
            mainForm.button1_panel2.Text = "Add Staff";

            mainForm.button2_panel2.Visible = true;
            mainForm.button2_panel2.Text = "Delete Staff";

            mainForm.button3_panel2.Visible = true;
            mainForm.button3_panel2.Text = "Update Staff";
            // buttons 

            // datagridviews
            mainForm.dataGridView1_panel2.Visible = true;
            //mainForm.dataGridView1_panel2.DataSource = Database.GetMembersTable();
            // datagridviews
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
