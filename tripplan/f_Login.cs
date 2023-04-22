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
    public partial class f_Login : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataTable app;
        
        
        public f_Login()
        {
            InitializeComponent();
            loadAccountList();
        }
        void loadAccountList ()
        {
            string strconn = "Server=localhost;Database=app_tripplanner;Port = 3306;User ID=root;Password=";
            conn = new MySqlConnection(strconn);
            conn.Open ();
            string query_select = "SELECT * FROM login;";
            cmd = new MySqlCommand(query_select);
            adap.Fill(app);
            conn.Close ();
        }
        private void f_Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_giaodien f = new f_giaodien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
