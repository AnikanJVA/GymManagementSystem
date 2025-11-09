using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        private string accType;
        private Equipment currentEquipment;

        public MainForm(string accType)
        {
            InitializeComponent();
            this.accType = accType;
            var view = Modules.CreateView(accType);
            view.RunModule(this);

            currentEquipment = new Equipment();

            FormatDataGrids();
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
                AdminModule.StafftMgmtButtonClick(this);
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
                TextBox[] requiredFields = {Equipments_textBox_name, Equipments_textBox_brand, Equipments_textBox_model,
                                            Equipments_textBox_cost, Equipments_textBox_quantity };
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        
                        isFieldsComplete = false;
                        break;
                    }
                    isFieldsComplete = true;
                }
                if (Equipments_comboBox_category.SelectedIndex == 0 || Equipments_comboBox_condition.SelectedIndex == 0)
                {
                    isFieldsComplete = false;
                }

                if (isFieldsComplete)
                {
                    bool isSuccessful = AdminActions.AddEquipment(Equipments_textBox_name.Text, Equipments_textBox_brand.Text, Equipments_textBox_model.Text, Equipments_comboBox_category.Text,
                                              Convert.ToInt64(Equipments_textBox_cost.Text), Convert.ToInt32(Equipments_textBox_quantity.Text), Equipments_comboBox_condition.Text);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Equipment Added.", "Success");
                        UpdateDataGridViews();
                    }
                    else
                    {
                        MessageBox.Show("Equipment Not Added. Equipment is duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Don't leave anything empty.", "Input Required",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_panel8_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {Equipments_textBox_name, Equipments_textBox_brand, Equipments_textBox_model,
                                            Equipments_textBox_cost, Equipments_textBox_quantity };
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {

                        isFieldsComplete = false;
                        break;
                    }
                    isFieldsComplete = true;
                }
                
                if (isFieldsComplete)
                {

                    bool isSuccessful = AdminActions.UpdateEquipment(Convert.ToInt64(Equipments_textBox_id.Text), Equipments_textBox_name.Text, Equipments_textBox_brand.Text, Equipments_textBox_model.Text, Equipments_comboBox_category.Text,
                                              Convert.ToInt64(Equipments_textBox_cost.Text), Convert.ToInt32(Equipments_textBox_quantity.Text), Equipments_comboBox_condition.Text);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Equipment updated.", "Success");
                        UpdateDataGridViews();
                    }
                    else
                    {
                        MessageBox.Show("Equipment not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void UpdateDataGridViews()
        {
            if (accType == "ADMIN")
            {
                Equipments_dataGridView.DataSource = Database.GetEquipmentsTable();
                dataGridView1_panel3.DataSource = Database.GetMembersTable();
                dataGridView1_panel6.DataSource = Database.GetStaffsTable();
                dataGridView1_panel9.DataSource = Database.GetUsersTable();
            }
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
                        break;
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.UserAccMgmtButtonClick(this);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.CoachingSessionsButtonClick(this);
            }
        }

        private void Equipments_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long equipmentID = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Equipments_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Equipments_dataGridView.Rows[e.RowIndex];
                        try
                        {
                            equipmentID = Convert.ToInt64(row.Cells["EquipmentID"].Value.ToString());
                            currentEquipment = Database.RetriveEquipment(equipmentID);
                        }
                        catch (Exception ex)
                        {

                        }
                        Equipment_AutoFill();
                    }
                    else
                    {
                        Equipment_ClearFill();
                    }
                }
            }
        }
        private void Equipments_button_clear_Click(object sender, EventArgs e)
        {
            Equipment_ClearFill();
        }

        public void Equipment_AutoFill()
        {
            Equipments_textBox_id.Text = currentEquipment.EquipmentID.ToString();
            Equipments_textBox_name.Text = currentEquipment.EquipmentName;
            Equipments_textBox_brand.Text = currentEquipment.Brand;
            Equipments_textBox_model.Text = currentEquipment.Model;
            Equipments_comboBox_category.Text = Database.GetEquipmentCategoryName(currentEquipment.CategoryID);
            Equipments_textBox_cost.Text = currentEquipment.Cost.ToString();
            Equipments_textBox_quantity.Text = currentEquipment.Quantity.ToString();
            Equipments_comboBox_condition.Text = currentEquipment.EquipmentCondition;
        }

        public void Equipment_ClearFill()
        {
            Equipments_textBox_id.Clear();
            Equipments_textBox_name.Clear();
            Equipments_textBox_brand.Clear();
            Equipments_textBox_model.Clear();
            Equipments_comboBox_category.SelectedIndex = -1;
            Equipments_textBox_cost.Clear();
            Equipments_textBox_quantity.Clear();
            Equipments_comboBox_condition.SelectedIndex = -1;
        }

        public void FormatDataGrids()
        {
            Equipments_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void button2_panel2_Click(object sender, EventArgs e)
        {

        }

        private void button3_panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
