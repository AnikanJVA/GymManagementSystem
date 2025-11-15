using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
            Form_comboBox_MembershipType.Text = "Solo";
        }

        private void MembershipType_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (Form_comboBox_MembershipType.Text == "Solo")
            {
                Solo_panel_info.Visible = true;
                Solo_panel_photo.Visible = true;
                Group_tabControl.Visible = false;
                ClearAllValues(Solo_panel_info);
            }
            else if (Form_comboBox_MembershipType.Text == "Group")
            {
                Solo_panel_info.Visible = false;
                Solo_panel_photo.Visible = false;
                Group_tabControl.Visible = true;
                ClearAllValues(Group_tabControl);
            }
        }

        private void ClearAllValues(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearAllValues(control);
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now; 
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private void Form_button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_button_add_Click(object sender, EventArgs e)
        {
            if (Form_comboBox_MembershipType.Text == "Solo")
            {

            }
            else if (Form_comboBox_MembershipType.Text == "Group")
            {

            }
        }
    }
}
