using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public class Modules
    {
        public static IModules CreateView (string moduleType)
        {
            if(moduleType == "ADMIN")
            {
                return new AdminModule();
            }
            else if (moduleType == "RECEPTIONIST")
            {
                return new ReceptionistModule();
            }
            else
            {
                throw new Exception("Error. Module not found.");
            }
        }
    }
}
