using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            UpdateDataGridViews();
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

        private void Sidebar_button1_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                AdminModule.DashboardButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
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
                //AdminModule.(this);
                MessageBox.Show("TO ADD MEMBER BUTTON FUNCTION");
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
                AdminModule.SalesButtonClick(this);
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
                AdminModule.PriceButtonClick(this);
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
                AdminModule.EquipmentButtonClick(this);
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
                AdminModule.UserAccMgmtButtonClick(this);
            }
            else if (accType == "RECEPTIONIST")
            {
                ReceptionistModule.DamagedButtonClick(this);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminModule.CoachingSessionsButtonClick(this);
        }

        private void Equipment_button_add_Click(object sender, EventArgs e)
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
                if (Equipments_comboBox_category.SelectedIndex == 0 )
                {
                    isFieldsComplete = false;
                }

                //    if (isFieldsComplete)
                //    {
                //        bool isSuccessful = AdminActions.AddEquipment(Equipments_textBox_name.Text, Equipments_textBox_brand.Text, Equipments_textBox_model.Text, Equipments_comboBox_category.Text,
                //                                  Convert.ToInt64(Equipments_textBox_cost.Text), Convert.ToInt32(Equipments_textBox_quantity.Text), Equipments_comboBox_condition.Text);
                //        if (isSuccessful)
                //        {
                //            MessageBox.Show("Equipment Added.", "Success");
                //            UpdateDataGridViews();
                //            Equipments_ClearFill();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Equipment Not Added. Equipment is duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Don't leave anything empty.", "Input Required",
                //                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
            }
        }
        private void Equipemnt_button_update_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {Equipments_textBox_name, Equipments_textBox_brand, Equipments_textBox_model,
                                            Equipments_textBox_cost, Equipments_textBox_quantity };
                foreach (TextBox tb in requiredFields)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text) || string.Equals(tb.Text, "0"))
                    {
                        isFieldsComplete = false;
                        break;
                    }
                    isFieldsComplete = true;
                }
                
                //if (isFieldsComplete)
                //{

                //    bool isSuccessful = AdminActions.UpdateEquipment(Convert.ToInt64(Equipments_textBox_id.Text), Equipments_textBox_name.Text, Equipments_textBox_brand.Text, Equipments_textBox_model.Text, Equipments_comboBox_category.Text,
                //                              Convert.ToInt64(Equipments_textBox_cost.Text), Convert.ToInt32(Equipments_textBox_quantity.Text), Equipments_comboBox_condition.Text);
                //    if (isSuccessful)
                //    {
                //        MessageBox.Show("Equipment updated.", "Success");
                //        UpdateDataGridViews();
                //        Equipments_ClearFill();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Equipment not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Don't leave anything empty.", "Input Required",
                //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void UpdateDataGridViews()
        {
            Equipments_dataGridView_equipments.DataSource = Database.GetEquipmentsTable();
            Staff_dataGridView_staff.DataSource = Database.GetStaffsTable();
            Users_dataGridView_users.DataSource = Database.GetUsersTable();
            Recep_members_dataGridView_members.DataSource = Database.GetMembersTable();
        }

        private void Staff_button_add_Click(object sender, EventArgs e)
        {
            if (accType == "ADMIN")
            {
                bool isFieldsComplete = false;
                TextBox[] requiredFields = {Staffs_textBox_fname, Staffs_textBox_mname, Staffs_textBox_lname,
                                           Staffs_textBox_contactNo, Staffs_textBox_email};
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

        private void Equipments_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long equipmentID = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = Equipments_dataGridView_equipments.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Equipments_dataGridView_equipments.Rows[e.RowIndex];
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
                        Equipments_ClearFill();
                    }
                }
            }
        }
        private void Equipments_button_clear_Click(object sender, EventArgs e)
        {
            Equipments_ClearFill();
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
        }

        public void Equipments_ClearFill()
        {
            Equipments_textBox_id.Clear();
            Equipments_textBox_name.Clear();
            Equipments_textBox_brand.Clear();
            Equipments_textBox_model.Clear();
            Equipments_comboBox_category.SelectedIndex = -1;
            Equipments_textBox_cost.Clear();
            Equipments_textBox_quantity.Clear();
        }

        public void FormatDataGrids()
        {
            Equipments_dataGridView_equipments.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Equipments_dataGridView_equipments.RowHeadersVisible = false;
        }
    }
}
