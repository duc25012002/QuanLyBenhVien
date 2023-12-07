using System.Data;
using System.Data.SqlClient;

namespace QuanLyBenhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hienThiBenhNhan();
            edtMaBenhAn.Enabled = false;
        }
        public void hienThiBenhNhan()
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dotNetCore;Integrated Security=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BenhNhan", conn);
            DataTable table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            grvBenhNhan.DataSource = table;
            conn.Close();

        }

        private void grvBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            edtMaBenhAn.Text = grvBenhNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
            edtHoTen.Text = grvBenhNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
            edtDiaChi.Text = grvBenhNhan.Rows[e.RowIndex].Cells[2].Value.ToString();
            edtGioiTinh.Text = grvBenhNhan.Rows[e.RowIndex].Cells[3].Value.ToString();
            pickerNgayNhapVien.Text = grvBenhNhan.Rows[e.RowIndex].Cells[4].Value.ToString();
            edtSoNgayDieuTri.Text = grvBenhNhan.Rows[e.RowIndex].Cells[5].Value.ToString();
            edtSoTienPhaiTra.Text = grvBenhNhan.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BenhNhan benhNhan = new BenhNhan(
                hoTen: edtHoTen.Text, 
                diaChi: edtDiaChi.Text,
                ngayNhapVien: pickerNgayNhapVien.Value,
                soNgayDieuTri: Int32.Parse (edtSoNgayDieuTri.Text),
                soTienPhaiTra: float.Parse(edtSoTienPhaiTra.Text),
                gioiTinh: edtGioiTinh.Text
                );
            benhNhan.capNhatThongTin();
            hienThiBenhNhan();

        }
    }
}