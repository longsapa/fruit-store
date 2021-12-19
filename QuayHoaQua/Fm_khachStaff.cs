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

namespace QuayHoaQua
{
    public partial class Fm_khachStaff : Form
    {
        private DataTable tblKH;
        public Fm_khachStaff()
        {
            InitializeComponent();
        }
        private void Fm_khachStaff_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from Khach";
            makhachtextBox.Enabled = false;
            savebutton.Enabled = false;
            LoadDataGridView();
        }
        private void ResetValues()
        {
            makhachtextBox.Text = "";
            tenkhachtextBox.Text = "";
            diachitextBox.Text = "";
            dienthoaimaskedTextBox.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Khach";
            tblKH = Functions.Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dataGridView1.DataSource = tblKH; //Hiển thị vào dataGridView
            dataGridView1.Columns[0].HeaderText = "Mã khách";
            dataGridView1.Columns[1].HeaderText = "Tên khách";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (addbutton.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makhachtextBox.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            makhachtextBox.Text = dataGridView1.CurrentRow.Cells["MaKhach"].Value.ToString();
            tenkhachtextBox.Text = dataGridView1.CurrentRow.Cells["TenKhach"].Value.ToString();
            diachitextBox.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            dienthoaimaskedTextBox.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            savebutton.Enabled = true;
            addbutton.Enabled = false;
            ResetValues();
            makhachtextBox.Text = Functions.Functions.CreateKey("2");
            makhachtextBox.Focus();
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (makhachtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makhachtextBox.Focus();
                return;
            }
            if (tenkhachtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tenkhachtextBox.Focus();
                return;
            }
            if (diachitextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diachitextBox.Focus();
                return;
            }
            if (dienthoaimaskedTextBox.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dienthoaimaskedTextBox.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKhach FROM Khach WHERE MaKhach=N'" + makhachtextBox.Text.Trim() + "'";
            if (Functions.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                makhachtextBox.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO Khach VALUES (N'" + makhachtextBox.Text.Trim() + "',N'" + tenkhachtextBox.Text.Trim() + "',N'" + diachitextBox.Text.Trim() + "','" + dienthoaimaskedTextBox.Text + "')";
            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            addbutton.Enabled = true;
            savebutton.Enabled = false;
            makhachtextBox.Enabled = false;
        }
        private void Fm_Khach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDataSet.Khach' table. You can move, or remove it, as needed.
            this.khachTableAdapter.Fill(this.banHangDataSet.Khach);

        }
    }
}
