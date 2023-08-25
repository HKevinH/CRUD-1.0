using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_SGBD.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace CRUD_SGBD
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Conex());
        }

    }
}
