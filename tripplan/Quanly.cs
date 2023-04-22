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

namespace tripplan
{
    class Quanly
    {
        public static MySqlConnection Conn;
        public static void Connect()
        {
            Conn = new MySqlConnection();
            MySqlDataAdapter adap;
            Conn.ConnectionString = "Server=localhost;Database=app_tripplanner;Port = 3306;User ID=root;Password=";
            Conn.Open();
            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công ");
            }
            else MessageBox.Show("Không thể kết nối dữ liệu");
        }
        public static void Disconnect()
        {
            if (Conn != null)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose(); 	//Giải phóng tài nguyên
                Conn = null;
            }
        }

    }
}
