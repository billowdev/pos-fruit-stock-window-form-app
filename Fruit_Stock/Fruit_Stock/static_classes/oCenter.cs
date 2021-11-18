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
    class oCenter
    {
        public static OleDbConnection conn = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", conn);
        public static OleDbDataAdapter da;
        public static OleDbDataReader rd;
        public static DataSet ds = new DataSet();

        public static string currentUsername;
        public static string currentStatus;
        public static string sql;

        public static bool IsFind = false;
        bool bCheckConnect = false;

        public static string getConnectionString()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" +
                Application.StartupPath + "/Database/db_fruit_stock.accdb;";

            return connectionString;
        }

        public void puvOpenConnection()
        {
            try
            {
                bCheckConnect = false;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = getConnectionString();
                    conn.Open();

                }
                bCheckConnect = true;
            }

            catch (Exception ex)
            {
                bCheckConnect = false;
                MessageBox.Show("ระบบไม่สามารถสร้างการเชื่อมต่อได้" + "\n" +
                    "รายละเอียด: " + ex.Message.ToString(), "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void pusvOpenConnection()
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

        public static void pusvCloseConnection()
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
    // Method ปิดหน้าซ้ำ
       public Boolean pub_CloseChildForm(Form _FrmCtrls, string _sFrmName)
        {
            foreach (Form Frm in _FrmCtrls.MdiChildren)
            {
                if (Frm.Name == _sFrmName)
                {
                    Frm.Focus();
                    return true;
                }
            }

            return false;
        }

        public DataSet puds_LoadData(string _sSql, string _sNameTable, DataSet _ds)
        {
            DataSet ds = new DataSet();
            try
            {
                _ds.Clear();
                if (bCheckConnect == false)
                {
                    puvOpenConnection();
                }
                OleDbDataAdapter oleDA = new OleDbDataAdapter(_sSql, conn);
                OleDbCommandBuilder oleCMDB = new OleDbCommandBuilder(oleDA);
                oleDA.Fill(_ds, _sNameTable);
                ds = _ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message.ToString(), "Msg",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return ds;
        }

        public bool pubActionData(string _sSql)
        {
            bool bCheck = false;
            try
            {
                if (bCheckConnect == false)
                {
                    pusvOpenConnection();
                }
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = _sSql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                bCheck = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message.ToString(), "Msg",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                bCheck = false;
            }
            return bCheck;
        }
    }
}
