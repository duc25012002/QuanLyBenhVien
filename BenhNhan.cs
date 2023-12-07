using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien
{
    internal class BenhNhan
    {
        private int maBenhAn;
        private string hoTen;
        private string diaChi;
        private string gioiTinh;
        private DateTime ngayNhapVien;
        private int soNgayDieuTri;
        private float soTienPhaiTra;
        private SqlConnection conn;

        public BenhNhan(string hoTen, string diaChi, string gioiTinh, DateTime ngayNhapVien, int soNgayDieuTri, float soTienPhaiTra)
        {

            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ngayNhapVien = ngayNhapVien;
            this.soNgayDieuTri = soNgayDieuTri;
            this.soTienPhaiTra = soTienPhaiTra;
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dotNetCore;Integrated Security=True;");
        }

        public int MaBenhAn { get => maBenhAn; set => maBenhAn = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayNhapVien { get => ngayNhapVien; set => ngayNhapVien = value; }
        public int SoNgayDieuTri { get => soNgayDieuTri; set => soNgayDieuTri = value; }
        public float SoTienPhaiTra { get => soTienPhaiTra; set => soTienPhaiTra = value; }

        public void capNhatThongTin()
        {
            SqlCommand sqlCommand = new SqlCommand($"UPDATE BenhNhan SET hoTen = '{this.hoTen}', diaChi = '{this.diaChi}', gioiTinh = '{this.gioiTinh}', ngayNhapVien = '{this.ngayNhapVien}', songayDieuTri = '{this.soNgayDieuTri}', soTienPhaiTra = '{this.soTienPhaiTra}'", conn);
            this.conn.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công!");
            this.conn.Close();
        }
    }
}