using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJSON
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            //if (args.Length > 0)
            //{
            //    if (args[0] == "geheim")
            //        MessageBox.Show("Super, du kennst das geheime Passwort!");
            //    else
            //    {
            //        MessageBox.Show("Zugriff verweigert!!! Vorsicht Selbstzerstörung!");
            //        return;
            //    }
            //}
            //else
            //    return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

    }
}
