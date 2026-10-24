using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroVentas.Presentación
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            {
              
                
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);

                    
              FrmLogo logo = new FrmLogo();
                logo.ShowDialog();
              Application.Run(new FrmLogin());

                
            }


        }
    }
}