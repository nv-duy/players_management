using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace contractsForm
{
    internal class HopdongDAO
    {
        DBConnection db = new DBConnection();

        public void ThemHopDong(Hopdong hd)
        {
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"INSERT INTO HOPDONG
    (
        MaCauThu,
        MaCLB,
        NgayBatDau,
        NgayKetThuc,
        MucLuong,
        TrangThai
    )
    VALUES
    (
        @MaCT,
        @MaCLB,
        @NgayBD,
        @NgayKT,
        @Luong,
        @TrangThai
    )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaCT", hd.MaCauThu);

            cmd.Parameters.AddWithValue("@MaCLB", hd.MaCLB);

            cmd.Parameters.AddWithValue("@NgayBD", hd.NgayBatDau);

            cmd.Parameters.AddWithValue("@NgayKT", hd.NgayKetThuc);

            cmd.Parameters.AddWithValue("@Luong", hd.MucLuong);

            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void SuaHopDong(
    int maHD,
    Hopdong hd)
        {
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"UPDATE HOPDONG
                   SET
                   MaCauThu = @MaCT,
                   MaCLB = @MaCLB,
                   NgayBatDau = @NgayBD,
                   NgayKetThuc = @NgayKT,
                   MucLuong = @Luong,
                   TrangThai = @TrangThai
                   WHERE MaHopDong = @MaHD";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHD", maHD);

            cmd.Parameters.AddWithValue("@MaCT", hd.MaCauThu);

            cmd.Parameters.AddWithValue("@MaCLB", hd.MaCLB);

            cmd.Parameters.AddWithValue("@NgayBD", hd.NgayBatDau);

            cmd.Parameters.AddWithValue("@NgayKT", hd.NgayKetThuc);

            cmd.Parameters.AddWithValue("@Luong", hd.MucLuong);

            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void XoaHopDong(int maHD)
        {
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql =
                "DELETE FROM HOPDONG WHERE MaHopDong = @MaHD";

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHD", maHD);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
