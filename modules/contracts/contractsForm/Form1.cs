using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;
namespace contractsForm
{
    public partial class QLHD : Form
    {
        public QLHD()
        {
            InitializeComponent();
        }
        List<Hopdong> dsHopDong = new List<Hopdong>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong();

            hd.MaCauThu = CbTenct.Text;

            hd.MaCLB = cbClb.Text;

            hd.NgayBatDau = dtpNgaybd.Value;

            hd.NgayKetThuc = dtpNgaykt.Value;

            hd.MucLuong =
                (double)nudLuong.Value;

            hd.TrangThai =
                CbTthd.Text;

            HopdongDAO dao = new HopdongDAO();

            dao.ThemHopDong(hd);

            MessageBox.Show("Thêm thành công");
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            LoadData();
            CbTenct.Items.Add("Messi");
            CbTenct.Items.Add("Ronaldo");
            CbTenct.Items.Add("Neymar");

            cbClb.Items.Add("Barcelona");
            cbClb.Items.Add("MU");
            cbClb.Items.Add("PSG");

            CbTthd.Items.Add("Còn hạn");
            CbTthd.Items.Add("Hết hạn");
        }
        public void LoadData()
        {
            DBConnection db = new DBConnection();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = "SELECT * FROM HOPDONG";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvHopDong.DataSource = dt;

            conn.Close();
        }
        private void dgvHopDong_CellClick(object sender,
    DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            CbTenct.Text =
                dgvHopDong.Rows[dong].Cells[1].Value.ToString();

            cbClb.Text =
                dgvHopDong.Rows[dong].Cells[2].Value.ToString();

            dtpNgaybd.Value =
                Convert.ToDateTime(
                    dgvHopDong.Rows[dong].Cells[3].Value);

            dtpNgaykt.Value =
                Convert.ToDateTime(
                    dgvHopDong.Rows[dong].Cells[4].Value);

            nudLuong.Value =
                Convert.ToDecimal(
                    dgvHopDong.Rows[dong].Cells[5].Value);

            CbTthd.Text =
                dgvHopDong.Rows[dong].Cells[6].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dong = dgvHopDong.CurrentRow.Index;

            int maHD = Convert.ToInt32(
                dgvHopDong.Rows[dong]
                .Cells[0].Value);

            Hopdong hd = new Hopdong();

            hd.MaCauThu = CbTenct.Text;

            hd.MaCLB = cbClb.Text;

            hd.NgayBatDau =
                dtpNgaybd.Value;

            hd.NgayKetThuc =
                dtpNgaykt.Value;

            hd.MucLuong =
                (double)nudLuong.Value;

            hd.TrangThai =
                CbTthd.Text;

            HopdongDAO dao = new HopdongDAO();

            dao.SuaHopDong(maHD, hd);

            LoadData();

            MessageBox.Show("Sửa thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dong = dgvHopDong.CurrentRow.Index;

            int maHD = Convert.ToInt32(
                dgvHopDong.Rows[dong]
                .Cells[0].Value);

            HopdongDAO dao = new HopdongDAO();

            dao.XoaHopDong(maHD);

            LoadData();

            MessageBox.Show("Xóa thành công");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"SELECT * FROM HOPDONG
                   WHERE
                   CAST(MaHopDong AS NVARCHAR)
                   LIKE @tk
                   OR MaCauThu LIKE @tk
                   OR MaCLB LIKE @tk
                   OR TrangThai LIKE @tk";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters
                .AddWithValue("@tk",
                "%" + txtTimKiem.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvHopDong.DataSource = dt;

            conn.Close();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sqlTong =
                "SELECT COUNT(*) FROM HOPDONG";

            string sqlConHan =
                "SELECT COUNT(*) FROM HOPDONG WHERE TrangThai = N'Còn hạn'";

            string sqlSapHetHan =
                @"SELECT COUNT(*) FROM HOPDONG
          WHERE DATEDIFF(day, GETDATE(),
          NgayKetThuc) <= 30";

            string sqlLuong =
                "SELECT SUM(MucLuong) FROM HOPDONG";

            SqlCommand cmdTong =
                new SqlCommand(sqlTong, conn);

            SqlCommand cmdConHan =
                new SqlCommand(sqlConHan, conn);

            SqlCommand cmdSapHetHan =
                new SqlCommand(sqlSapHetHan, conn);

            SqlCommand cmdLuong =
                new SqlCommand(sqlLuong, conn);

            int tong =
                (int)cmdTong.ExecuteScalar();

            int conHan =
                (int)cmdConHan.ExecuteScalar();

            int sapHetHan =
                (int)cmdSapHetHan.ExecuteScalar();

            double tongLuong =
                Convert.ToDouble(
                    cmdLuong.ExecuteScalar());

            MessageBox.Show(
                "Tổng hợp đồng: " + tong +
                "\nCòn hạn: " + conHan +
                "\nSắp hết hạn: " + sapHetHan +
                "\nTổng quỹ lương: " + tongLuong);

            conn.Close();
        }
    }
}
