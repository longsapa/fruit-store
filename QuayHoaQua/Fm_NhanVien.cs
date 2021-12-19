using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuayHoaQua.Functions;

namespace QuayHoaQua
{
    public partial class Fm_NhanVien : Form
    {
        private DataTable tblNV;
        public Fm_NhanVien()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtmanhanvien.Text = "";
            txtHoTen.Text = "";
            cbbgioitinh.Text = "";
            txtdiachi.Text = "";
            mtbngaysinh.Value = DateTime.Now;
            mtbdienthoai.Text = "";
            Passtextbox.Text = "";
            ChucVuTextBox.Text = "";
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROm NhanVien";
            tblNV = Functions.Functions.GetDataToTable(sql); //lấy dữ liệu
            dataGridView1.DataSource = tblNV;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Điện thoại";
            dataGridView1.Columns[5].HeaderText = "Ngày sinh";
            dataGridView1.Columns[6].HeaderText = "Mật khẩu";
            dataGridView1.Columns[7].HeaderText = "Chức Vụ";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dataGridview1_click(object sender, EventArgs e)
        {
            if (btadd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanhanvien.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            cbbgioitinh.Text = dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbdienthoai.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
            mtbngaysinh.Value = (DateTime)dataGridView1.CurrentRow.Cells["NgaySinh"].Value;
            Passtextbox.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            ChucVuTextBox.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
            btfix.Enabled = true;
            btdelete.Enabled = true;
            btdelete.Enabled = true;
        }

        private void btadd_Click_1(object sender, EventArgs e)
        {
            
            btdelete.Enabled = false;
            savebt.Enabled = true;
            btadd.Enabled = false;
            ResetValues();
            txtmanhanvien.Text = Functions.Functions.CreateKey2("1");
            txtmanhanvien.Focus();
            Passtextbox.Enabled = true;
        }

        
        
        private void Fm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from NhanVien";
            txtmanhanvien.Enabled = false;
            savebt.Enabled = false;
            LoadDataGridView();

        }

        

        

        private void btfix_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbdienthoai.Focus();
                return;
            }
            if (mtbngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbngaysinh.Focus();
                return;
            }
            if (!Functions.Functions.IsDate(mtbngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbngaysinh.Text = "";
                mtbngaysinh.Focus();
                return;
            }
            if (cbbgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải Chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbgioitinh.Focus();
                return;
            }
            sql = "UPDATE NhanVien SET  Hoten=N'" + txtHoTen.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtdiachi.Text.Trim().ToString() +
                    "',DienThoai='" + mtbdienthoai.Text.ToString() + 
                    "',Gioitinh='" + cbbgioitinh.Text.ToString() +
                    "',NgaySinh='" + mtbngaysinh.Value +
                    "',Password='" + Passtextbox.Text.ToString() +
                    "',ChucVu='" + ChucVuTextBox.Text.ToString() +
                    "' WHERE ID=N'" + txtmanhanvien.Text + 
                    "'";
            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE ID=N'" + txtmanhanvien.Text + "'";
                Functions.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
                if (btadd.Enabled == false)
                {
                    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmanhanvien.Focus();
                    return;
                }
                if (tblNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtmanhanvien.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txtHoTen.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
                cbbgioitinh.Text = dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString();
                txtdiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
                mtbdienthoai.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
                mtbngaysinh.Value = (DateTime)dataGridView1.CurrentRow.Cells["NgaySinh"].Value;
                Passtextbox.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                ChucVuTextBox.Text = dataGridView1.CurrentRow.Cells["ChucVu"].Value.ToString();
                btfix.Enabled = true;
                btdelete.Enabled = true;
                btdelete.Enabled = true;
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebt_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmanhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanhanvien.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbdienthoai.Focus();
                return;
            }


            if (cbbgioitinh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbgioitinh.Focus();
                return;
            }
            sql = "SELECT ID FROM NhanVien WHERE ID=N'" + txtmanhanvien.Text.Trim() + "'";
            if (Functions.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanhanvien.Focus();
                txtmanhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien(ID,Hoten,Gioitinh, DiaChi,DienThoai,NgaySinh,Password,ChucVu) VALUES (N'" + txtmanhanvien.Text.Trim() + "',N'" + txtHoTen.Text.Trim() + "',N'" + cbbgioitinh.Text + "',N'" + txtdiachi.Text.Trim() + "','" + mtbdienthoai.Text + "','" + mtbngaysinh.Value + "','" + Passtextbox.Text + "','" + ChucVuTextBox.Text + "')";
            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btdelete.Enabled = true;
            btadd.Enabled = true;
            btfix.Enabled = true;
            savebt.Enabled = false;
            txtmanhanvien.Enabled = false;

            }

        private void cbbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    