using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuayHoaQua.Functions;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace QuayHoaQua
{
    public partial class Fm_HoaDonStaff : Form
    {
        private DataTable tblCTHDB;
        public Fm_HoaDonStaff()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ResetValuesHang()
        {
            mahangcomboBox.Text = "";
            soluongtextBox.Text = "";
            giamgiatextBox.Text = "0";
            thanhtientextBox.Text = "0";
        }
        private void ResetValues()
        {
            mahdtextBox.Text = "";
            ngaybanmaskedTextBox.Value = DateTime.Now;
            idnhanviencomboBox.Text = "";
            makhachhangcomboBox.Text = "";
            tongtientextBox.Text = "0";
            mahangcomboBox.Text = "";
            soluongtextBox.Text = "";
            giamgiatextBox.Text = "0";
            thanhtientextBox.Text = "0";
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM HoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'";
            ngaybanmaskedTextBox.Value = DateTime.Now;
            str = "SELECT ID FROM HoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'";
            idnhanviencomboBox.Text = Functions.Functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM HoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'";
            makhachhangcomboBox.Text = Functions.Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM HoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'";
            tongtientextBox.Text = Functions.Functions.GetFieldValues(str);
        }
        private void Fm_HoaDon_Load(object sender, EventArgs e)
        {
            addbutton.Enabled = true;
            savebutton.Enabled = false;
            deletebutton.Enabled = false;
            printbutton.Enabled = false;
            mahdtextBox.ReadOnly = true;
            HoTentextBox.ReadOnly = true;
            tenkhachtextBox.ReadOnly = true;
            diachitextBox.ReadOnly = true;
            dienthoaitextBox.ReadOnly = true;
            tenhangtextBox.ReadOnly = true;
            dongiatextBox.ReadOnly = true;
            thanhtientextBox.ReadOnly = true;
            tongtientextBox.ReadOnly = true;
            giamgiatextBox.Text = "0";
            tongtientextBox.Text = "0";
            Functions.Functions.FillCombo("SELECT MaKhach, TenKhach FROM Khach", makhachhangcomboBox, "MaKhach", "MaKhach");
            makhachhangcomboBox.SelectedIndex = -1;
            Functions.Functions.FillCombo("SELECT ID, HoTen FROM NhanVien", idnhanviencomboBox, "ID", "TenKhach");
            idnhanviencomboBox.SelectedIndex = -1;
            Functions.Functions.FillCombo("SELECT MaHang, TenHang FROM Hang", mahangcomboBox, "MaHang", "MaHang");
            mahangcomboBox.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (mahdtextBox.Text != "")
            {
                LoadInfoHoaDon();
                deletebutton.Enabled = true;

            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, a.DonGia, a.GiamGia,a.ThanhTien FROM ChiTietHoaDon AS a, Hang AS b WHERE a.MaHD = N'" + mahdtextBox.Text + "' AND a.MaHang=b.MaHang";
            tblCTHDB = Functions.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCTHDB;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Giảm giá %";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            deletebutton.Enabled = false;
            savebutton.Enabled = true;
            printbutton.Enabled = false;
            addbutton.Enabled = false;
            ResetValues();
            mahdtextBox.Text = Functions.Functions.CreateKey("HDB");
            LoadDataGridView();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHD FROM HoaDon WHERE MaHD=N'" + mahdtextBox.Text + "'";
            if (!Functions.Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (ngaybanmaskedTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ngaybanmaskedTextBox.Focus();
                    return;
                }
                if (idnhanviencomboBox.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idnhanviencomboBox.Focus();
                    return;
                }
                if (makhachhangcomboBox.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makhachhangcomboBox.Focus();
                    return;
                }

                sql = "INSERT INTO HoaDon(MaHD, NgayBan, ID, MaKhach, TongTien) VALUES (N'" + mahdtextBox.Text.Trim() + "','" +
                        ngaybanmaskedTextBox.Value + "',N'" + idnhanviencomboBox.SelectedValue + "',N'" +
                        makhachhangcomboBox.SelectedValue + "'," + tongtientextBox.Text + ")";
                Functions.Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (mahangcomboBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mahangcomboBox.Focus();
                return;
            }
            if ((soluongtextBox.Text.Trim().Length == 0) || (soluongtextBox.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                soluongtextBox.Text = "";
                soluongtextBox.Focus();
                return;
            }
            if (giamgiatextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giamgiatextBox.Focus();
                return;
            }
            sql = "SELECT MaHang FROM ChiTietHoaDon WHERE MaHang=N'" + mahangcomboBox.SelectedValue + "' AND MaHD = N'" + mahdtextBox.Text.Trim() + "'";
            if (Functions.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                mahangcomboBox.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + mahangcomboBox.SelectedValue + "'"));
            if (Convert.ToDouble(soluongtextBox.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                soluongtextBox.Text = "";
                soluongtextBox.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHoaDon(MaHD,MaHang,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + mahdtextBox.Text.Trim() + "',N'" + mahangcomboBox.SelectedValue + "'," + soluongtextBox.Text + "," + dongiatextBox.Text + "," + giamgiatextBox.Text + "," + thanhtientextBox.Text + ")";
            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(soluongtextBox.Text);
            sql = "UPDATE Hang SET SoLuong =" + SLcon + " WHERE MaHang= N'" + mahangcomboBox.SelectedValue + "'";
            Functions.Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.Functions.GetFieldValues("SELECT TongTien FROM HoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(thanhtientextBox.Text);
            sql = "UPDATE HoaDon SET TongTien =" + Tongmoi + " WHERE MaHD = N'" + mahdtextBox.Text + "'";
            Functions.Functions.RunSQL(sql);
            tongtientextBox.Text = Tongmoi.ToString();

            ResetValuesHang();
            deletebutton.Enabled = true;
            addbutton.Enabled = true;
            printbutton.Enabled = true;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaHang,SoLuong FROM ChiTietHoaDon WHERE MaHD = N'" + mahdtextBox.Text + "'";
                DataTable Hang = Functions.Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= Hang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + Hang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(Hang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + Hang.Rows[hang][0].ToString() + "'";
                    Functions.Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE ChiTietHoaDon WHERE MaHD=N'" + mahdtextBox.Text + "'";
                Functions.Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE HoaDon WHERE MaHD=N'" + mahdtextBox.Text + "'";
                Functions.Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                deletebutton.Enabled = false;
                printbutton.Enabled = false;
            }
        }

        private void idnhanviencomboBox_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (idnhanviencomboBox.Text == "")
                HoTentextBox.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select HoTen from NhanVien where ID =N'" + idnhanviencomboBox.SelectedValue + "'";
            HoTentextBox.Text = Functions.Functions.GetFieldValues(str);
        }

        private void makhachhangcomboBox_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (makhachhangcomboBox.Text == "")
            {
                tenkhachtextBox.Text = "";
                diachitextBox.Text = "";
                dienthoaitextBox.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKhach from Khach where MaKhach = N'" + makhachhangcomboBox.SelectedValue + "'";
            tenkhachtextBox.Text = Functions.Functions.GetFieldValues(str);
            str = "Select DiaChi from Khach where MaKhach = N'" + makhachhangcomboBox.SelectedValue + "'";
            diachitextBox.Text = Functions.Functions.GetFieldValues(str);
            str = "Select DienThoai from Khach where MaKhach= N'" + makhachhangcomboBox.SelectedValue + "'";
            dienthoaitextBox.Text = Functions.Functions.GetFieldValues(str);
        }

        private void mahangcomboBox_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (mahangcomboBox.Text == "")
            {
                tenhangtextBox.Text = "";
                dongiatextBox.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenHang FROM Hang WHERE MaHang =N'" + mahangcomboBox.SelectedValue + "'";
            tenhangtextBox.Text = Functions.Functions.GetFieldValues(str);
            str = "SELECT GiaBan FROM Hang WHERE MaHang =N'" + mahangcomboBox.SelectedValue + "'";
            dongiatextBox.Text = Functions.Functions.GetFieldValues(str);
        }

        private void soluongtextBox_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (soluongtextBox.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(soluongtextBox.Text);
            if (giamgiatextBox.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(giamgiatextBox.Text);
            if (dongiatextBox.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(thanhtientextBox.Text);
            tt = sl * dg - sl * dg * gg / 100;
            thanhtientextBox.Text = tt.ToString();
        }



        private void soluongtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void giamgiatextBox_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (soluongtextBox.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(soluongtextBox.Text);
            if (giamgiatextBox.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(giamgiatextBox.Text);
            if (dongiatextBox.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(dongiatextBox.Text);
            tt = sl * dg - sl * dg * gg / 100;
            thanhtientextBox.Text = tt.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tongtientextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Vjp";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "SaPa";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0123123123";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHD, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.HoTen FROM HoaDon AS a, Khach AS b, NhanVien AS c WHERE a.MaHD = N'" + mahdtextBox.Text + "' AND a.MaKhach = b.MaKhach AND a.ID = c.ID";
            tblThongtinHD = Functions.Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenHang, a.SoLuong, b.GiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM ChiTietHoaDon AS a , Hang AS b WHERE a.MaHD = N'" +
                  mahdtextBox.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = Functions.Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;

            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
    }
}
