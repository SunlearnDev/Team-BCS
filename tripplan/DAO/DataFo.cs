using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tripplan.DAO
{
    public class DataFo
    {
        public MySqlConnection conn;
        private  MySqlCommandBuilder cmd;
        private MySqlDataAdapter adap;
        private DataTable app;
        private string strconn = "Server=localhost;Database=app_tripplanner;Port = 3306;User ID=root;Password=";

        public DataFo()
        {
            conn = new MySqlConnection(strconn);
        }
        private void OpenConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Open();
            }
        }
        private void ClosenConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public DataTable GetDataTable(string query_select)
        {
            this.OpenConn();

            DataTable tb = new DataTable();

            MySqlDataAdapter adp = new MySqlDataAdapter(query_select, this.conn);
            adp.Fill(tb);

            this.ClosenConn();
            return tb;

        }
        public int ExecuteSQL(String mysql)
        {
            this.OpenConn();
            int k = 0;
            MySqlCommand cmd = new MySqlCommand(mysql,this.conn);
            k=cmd.ExecuteNonQuery();
            this.ClosenConn();
            return k;
        }
              
    }
}
