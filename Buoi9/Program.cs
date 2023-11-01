using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi9
{
    public class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            SqlConnection connect = new SqlConnection("Data Source = A209PC13; Initial Catalog = QLSinhVien; Integrated Security = True");

        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
