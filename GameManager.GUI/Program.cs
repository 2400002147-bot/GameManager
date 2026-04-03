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

                // Đảm bảo FormLogin là tên chính xác của Form đăng nhập của bạn
                Application.Run(new FormLogin());
            }
        }
    }
