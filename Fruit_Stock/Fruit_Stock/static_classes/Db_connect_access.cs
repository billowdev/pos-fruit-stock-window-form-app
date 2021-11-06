using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Fruit_Stock.static_classes
{
    class Db_connect
    {
        public static OleDbConnection conn = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", conn);
        public static OleDbDataAdapter da;

        public static string currentFullName;
        public static string sql;

        public static string getConnectionString()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" +
                Application.StartupPath + "/db_login.accdb;";

            return connectionString;
        }

        public static void openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = getConnectionString();
                    conn.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ระบบไม่สามารถสร้างการเชื่อมต่อได้" + "\n" +
                    "รายละเอียด: " + ex.Message.ToString(), "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Close Connection Failed");

            }
        }
    }
}
