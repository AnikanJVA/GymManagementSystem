using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public class CoachModule : IModules
    {
        public void RunModule(MainForm mainForm)
        {
            mainForm.Label_greetings.Text = "Welcome\nCoach!";

            mainForm.button1.Text = "Dashboard";
            mainForm.button1.Visible = true;

            mainForm.button2.Text = "Sessions";
            mainForm.button2.Visible = true;

            mainForm.panel1.Visible = true;
            mainForm.label1.Text = "Dashboard";

            mainForm.panel2.Visible = false;
            mainForm.label2.Text = "Sessions";

            mainForm.button_logout.Margin = new System.Windows.Forms.Padding(
                    mainForm.button_logout.Margin.Left,
                    mainForm.button_logout.Margin.Top + 235,
                    mainForm.button_logout.Margin.Right,
                    mainForm.button_logout.Margin.Bottom
            ); 
        }

        public static void DashboardButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = true;
            mainForm.panel2.Visible = false;
        }

        public static void SessionsButtonClick(MainForm mainForm)
        {
            mainForm.panel1.Visible = false;
            mainForm.panel2.Visible = true;
        }
    }
}
