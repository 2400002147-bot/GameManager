using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.GUI
{ 
internal static class Program
{
          
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("UserName:admin\nPassword: admin", "Thông tin", MessageBoxButtons.OK);
                Application.Run(new FormLogin());
            }
        }
    }
