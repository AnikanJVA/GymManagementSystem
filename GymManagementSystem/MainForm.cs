using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        public string accType;

        public MainForm(string accType)
        {
            InitializeComponent();
            this.accType = accType;
            var view = Modules.CreateView(accType);
            view.RunModule(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Database.Instance.Connection.Close();
            FormProvider.Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(accType == "ADMIN")
            {
                AdminModule.DashboardButtonClick(this);
            }
            else if(accType == "RECEPTIONIST")
            {
                ReceptionistModule.DashboardButtonClick(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.AccountMgmtButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.MemberMgmtButtonClick(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.BanButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.CheckInButtonClick(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.ExpensesButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.CoachingButtonClick(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.SalesButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.PaymentButtonClick(this);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.PayrollButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.EquipmentButtonClick(this);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.CostButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.DamagedButtonClick(this);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminModule.EquipmentButtonClick(this);
        }

        private void button1_panel8_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {textBox2_panel8, textBox3_panel8, textBox4_panel8,
                                            textBox5_panel8, textBox6_panel8, textBox7_panel8, textBox8_panel8};
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        MessageBox.Show("Don't leave anything empty.", "Input Required",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isFieldsComplete = false;
                        break;
                    }
                    isFieldsComplete = true;
                }

                if (isFieldsComplete)
                {
                    bool isSuccessful = AdminActions.AddEquipment(textBox2_panel8.Text, textBox3_panel8.Text, textBox4_panel8.Text, textBox5_panel8.Text,
                                              Convert.ToInt64(textBox6_panel8.Text), Convert.ToInt32(textBox7_panel8.Text), textBox8_panel8.Text);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Equipment Added.", "Success");
                        UpdateDataGridViews();
                    }
                    else
                    {
                        MessageBox.Show("Equipment Not Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        private void button2_panel8_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {textBox2_panel8, textBox3_panel8, textBox4_panel8,
                                            textBox5_panel8, textBox6_panel8, textBox7_panel8, textBox8_panel8};
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        MessageBox.Show("Don't leave anything empty.", "Input Required",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isFieldsComplete = false;
                        return;
                    }
                    isFieldsComplete = true;
                }
                if (isFieldsComplete)
                {

                    bool isSuccessful = AdminActions.UpdateEquipment(textBox2_panel8.Text, textBox3_panel8.Text, textBox4_panel8.Text, textBox5_panel8.Text,
                                              Convert.ToInt64(textBox6_panel8.Text), Convert.ToInt32(textBox7_panel8.Text), textBox8_panel8.Text);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Equipment Added.", "Success");
                        UpdateDataGridViews();
                    }
                    else
                    {
                        MessageBox.Show("Equipment Not Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void UpdateDataGridViews()
        {
            if (accType == "ADMIN")
            {
                dataGridView1_panel8.DataSource = Database.GetEquipmentsTable();
                dataGridView1_panel3.DataSource = Database.GetMembersTable();
                dataGridView1_panel6.DataSource = Database.GetStaffTable();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_panel8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_panel2_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {textBox1_panel2, textBox2_panel2, textBox3_panel2,
                                           textBox4_panel2, textBox5_panel2};
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        MessageBox.Show("Don't leave anything empty.", "Input Required",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isFieldsComplete = false;
                        return;
                    }
                    isFieldsComplete = true;
                }

                if (isFieldsComplete)
                {
                    //string dob = dateTimePicker1_panel2.Value.ToString("yyyy-MM-dd");
                    //bool isSuccessful = AdminActions.AddStaff(textBox1_panel2.Text, textBox2_panel2.Text, comboBox1_panel2.Text, textBox3_panel2.Text, textBox4_panel2.Text,
                    //                                                dob, comboBox2_panel2.Text, textBox5_panel2.Text);
                    //if (isSuccessful)
                    //{
                    //    MessageBox.Show("Equipment Added.", "Success");
                    //    UpdateDataGridViews();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Equipment Not Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}
                }
            }
        }
    }
}
