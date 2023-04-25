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
using MySqlX.XDevAPI;
//using tripplan.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tripplan
{
    public partial class f_giaodien : Form
    {
         MySqlConnection conn ;
         MySqlCommandBuilder cmd ;
         MySqlDataAdapter adap ;
         MySqlDataAdapter dapps;
         DataTable app = new DataTable();
         string strconn = "Server=localhost;Database=app_tripplanner;Port = 3306;User ID=root;Password=";
         string query_select = "SELECT * FROM hotel;";
        //private static DataFo dataAccess;
        public f_giaodien()
        {
            InitializeComponent();
            //dataAccess = new DataFo();
        }
        private void f_giaodien_Load(object sender, EventArgs e)
        {
            try
            {
                Read_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Hotel_Click(object sender, EventArgs e)
        {

            butXoa.Enabled = true;
            buttSua.Enabled = true;
            buttSearch.Enabled = true;
            butThem.Enabled = true;
            butLuu.Enabled = true;
            buttThoat.Enabled = true;
        }
        private void ResetValue()
        {
            TxtMaHotel.Text = "";
            TxtEmail.Text = "";
            TxtHoline.Text = "";
            TxtName.Text = "";
            TxtAdd.Text = "";
            TxtPrice.Text = "";
            TxtDanhgia.Text = "";
            TxtCmt.Text = "";
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            butXoa.Enabled = false;
            buttSua.Enabled = false;
            buttSearch.Enabled = false;
            butThem.Enabled = false;
            butLuu.Enabled=true;
            ResetValue();
            TxtAdd.Enabled = true;
            TxtPrice.Enabled = true;
            TxtDanhgia.Enabled = true;
            TxtCmt.Enabled = true; 
            TxtMaHotel.Enabled = true;
            TxtPrice.Enabled = true;
            TxtEmail.Enabled = true;
            TxtName.Enabled = true;
        }

        private void buttSua_Click(object sender, EventArgs e)
        {
            ResetValue();
            conn.Open();
            string maHotel = TxtMaHotel.Text;
            string tenKhachSan = TxtName.Text;
            string dienThoai = TxtHoline.Text;
            string diaChi = TxtAdd.Text;
            string GiaPhong = TxtPrice.Text;
            string DanhGia = TxtDanhgia.Text;
            string Mysqlsua = "UPDATE hotel SET 'ten_khach_san' ='" + tenKhachSan + "'dien_thoai ='" + dienThoai + "'dia_chi ='" + diaChi + "'Giatien ='" + GiaPhong + "'Rating' =" + DanhGia + "', ' WHERE id_hotel = "+ maHotel + "'  ";
            MySqlCommand commd = new MySqlCommand(Mysqlsua, conn);
            commd.ExecuteNonQuery();
            conn.Close();
            Read_data();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            ResetValue();
            conn.Open();
            string maHotel = TxtMaHotel.Text;
            string tenKhachSan = TxtName.Text;
            string Dell = "Delete From hotel SET 'ten_khach_san' ='" + tenKhachSan + "' ' WHERE id_hotel = " + maHotel + "'  ";
            MySqlCommand commd = new MySqlCommand(Dell, conn);
            commd.ExecuteNonQuery();
            conn.Close();
            Read_data();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            string maHotel = TxtMaHotel.Text;
            string tenKhachSan = TxtName.Text;
            string dienThoai = TxtHoline.Text;
            string diaChi = TxtAdd.Text;
            string GiaPhong = TxtPrice.Text;
            string DanhGia = TxtDanhgia.Text;
            string mysql = "INSERT INTO hotel(id_hotel,ten_khach_san,Giatien,dien_thoai,Rating,dia_chi) VALUES('" + maHotel + "','" + tenKhachSan + "','" + GiaPhong + "','" + dienThoai + "','" + DanhGia + "' ,'" + diaChi + "')";
            MySqlCommand commd = new MySqlCommand(mysql,conn);
            commd.ExecuteNonQuery();
            conn.Close();
            Read_data();
        }
        private void buttSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void buttThoat_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Bạn chắc chắn muốn thoát ", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);        
                }
        }

        private void DgvHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       private void Read_data()
        {
            conn = new MySqlConnection(strconn);
            adap = new MySqlDataAdapter(query_select, conn);
            cmd = new MySqlCommandBuilder(adap);
            app = new DataTable();
            adap.Fill(app);
            DgvHotel.DataSource = app;
        }
    }
}
