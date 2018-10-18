using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGVB
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SIG.FrmSplash());
            SIG.FrmLogin flogin = new SIG.FrmLogin();


            flogin.ShowDialog();

            if (flogin.logado)
            {
                Application.Run(new SIG.FrmPrincipal());

            }
        }
    }
}
