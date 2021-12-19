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
    public partial class Fm_Kho : Form
    {
        private DataTable tbH;
        public Fm_Kho()
        {
            InitializeComponent();
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from Kho";
            mahangtextBox.Enabled = false;
            savebutton.Enabled = false;
            TenNCCtextBox.Enabled = false;
            Functions.Functions.FillCombo("SELECT MaNhaCung, TenNhaCung FROM NhaCungCap", MaNCCcombobox, "MaNhaCung", "TenKhach");
            MaNCCcombobox.SelectedIndex = -1;
            LoadDataGridView();
            ResetValues();
        }
        private void ResetValues()
        {
            mahangtextBox.Text = "";
            tenhangtextBox.Text = "";
            soluongtextBox.Text = "0";
            gianhaptextBox.Text = "0";
            giabantextBox.Text = "0";
            soluongtextBox.Enabled = true;
            gianhaptextBox.Enabled = false;
            giabantextBox.Enabled = false;
            anhtextBox.Text = "";
            pictureBox1.Image = null;
            ghichutextBox.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHang,TenHang,SoLuong,GiaNhap,GiaBan,Anh,MaNhaCung,GhiChu from Hang";
            tbH = Functions.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tbH;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[4].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[5].HeaderText = "Ảnh";
            dataGridView1.Columns[6].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[7].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 300;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (addbutton.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mahangtextBox.Focus();
                return;
            }
            if (tbH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mahangtextBox.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            tenhangtextBox.Text = dataGridView1.CurrentRow.Cells["TenHang"].Value.ToString();
            soluongtextBox.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            gianhaptextBox.Text = dataGridView1.CurrentRow.Cells["GiaNhap"].Value.ToString();
            giabantextBox.Text = dataGridView1.CurrentRow.Cells["GiaBan"].Value.ToString();
            sql = "SELECT Anh FROM Hang WHERE MaHang=N'" + mahangtextBox.Text + "'";
            anhtextBox.Text = Functions.Functions.GetFieldValues(sql);
            pictureBox1.Image = Image.FromFile(anhtextBox.Text);
            sql = "SELECT Ghichu FROM Hang WHERE MaHang = N'" + mahangtextBox.Text + "'";
            ghichutextBox.Text = Functions.Functions.GetFieldValues(sql);
            MaNCCcombobox.Text = dataGridView1.CurrentRow.Cells["MaNhaCung"].Value.ToString();
            fixbutton.Enabled = true;
            deletebutton.Enabled = true;
            
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            fixbutton.Enabled = false;
            deletebutton.Enabled = false;
            savebutton.Enabled = true;
            addbutton.Enabled = false;
            ResetValues();
            mahangtextBox.Enabled = true;
            mahangtextBox.Focus();
            soluongtextBox.Enabled = true;
            gianhaptextBox.Enabled = true;
            giabantextBox.Enabled = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (mahangtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mahangtextBox.Focus();
                return;
            }
            if (tenhangtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tenhangtextBox.Focus();
                return;
            }
            
            if (anhtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewbutton.Focus();
                return;
            }
            sql = "SELECT MaHang FROM Hang WHERE MaHang=N'" + mahangtextBox.Text.Trim() + "'";
            if (Functions.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mahangtextBox.Focus();
                return;
            }
            sql = "INSERT INTO Hang(MaHang,TenHang,SoLuong,GiaNhap, GiaBan,Anh,Ghichu,MaNhaCung) VALUES(N'"
                + mahangtextBox.Text.Trim() + "',N'" + tenhangtextBox.Text.Trim() +
                "'," + soluongtextBox.Text.Trim() + "," + gianhaptextBox.Text +
                "," + giabantextBox.Text + ",'" + anhtextBox.Text + "',N'" + ghichutextBox.Text.Trim() + "',N'" + MaNCCcombobox.Text + "')";

            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            deletebutton.Enabled = true;
            addbutton.Enabled = true;
            fixbutton.Enabled = true;
            savebutton.Enabled = false;
            mahangtextBox.Enabled = false;
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                anhtextBox.Text = dlgOpen.FileName;
            }
        }

        private void fixbutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mahangtextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mahangtextBox.Focus();
                return;
            }
            if (tenhangtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tenhangtextBox.Focus();
                return;
            }
          
            if (anhtextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anhtextBox.Focus();
                return;
            }
            sql = "UPDATE Hang SET TenHang=N'" + tenhangtextBox.Text.Trim().ToString() +
                "',SoLuong=" + soluongtextBox.Text +
                ",Anh='" + anhtextBox.Text + "',Ghichu=N'" + ghichutextBox.Text + "',MaNhaCung=N'" + MaNCCcombobox.Text + "' WHERE MaHang=N'" + mahangtextBox.Text + "'";
            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mahangtextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Hang WHERE MaHang=N'" + mahangtextBox.Text + "'";
                Functions.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MaNCCcombobox_TextChanged(object sender, EventArgs e)
        {

            string str;
            if (MaNCCcombobox.Text == "")
            {
                TenNCCtextBox.Text = "";
            }
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNhaCung from NhaCungCap where MaNhaCung =N'" + MaNCCcombobox.SelectedValue + "'";
            TenNCCtextBox.Text = Functions.Functions.GetFieldValues(str);
        }
    }
}
