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
    public partial class Fm_NhaCungCap : Form
    {
        private DataTable tbH;
        public Fm_NhaCungCap()
        {
            InitializeComponent();
        }
        private void Fm_NhaCungCap_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from NhaCungCap";
            Mancctextbox.Enabled = false;
            savebutton.Enabled = false;
            LoadDataGridView();
            ResetValues();
        }
        private void ResetValues()
        {
            Mancctextbox.Text = "";
            TenncctextBox.Text = "";
            diachitextbox.Text = "";
            sdttextBox.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NhaCungCap";
            tbH = Functions.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tbH;
            dataGridView1.Columns[0].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            string sql;
            if (addbutton.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mancctextbox.Focus();
                return;
            }
            if (tbH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Mancctextbox.Text = dataGridView1.CurrentRow.Cells["MaNhaCung"].Value.ToString();
            TenncctextBox.Text = dataGridView1.CurrentRow.Cells["TenNhaCung"].Value.ToString();
            diachitextbox.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            sdttextBox.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
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
            Mancctextbox.Enabled = true;
            Mancctextbox.Focus();
            TenncctextBox.Enabled = true;
            diachitextbox.Enabled = true;
            sdttextBox.Enabled = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (Mancctextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mancctextbox.Focus();
                return;
            }
            if (TenncctextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TenncctextBox.Focus();
                return;
            }
            sql = "SELECT MaNhaCung FROM NhaCungCap WHERE MaNhaCung=N'" + Mancctextbox.Text.Trim() + "'";
            if (Functions.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung này đã tồn tại, bạn phải chọn mã nhà cung khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mancctextbox.Focus();
                return;
            }
            sql = "INSERT INTO NhaCungCap(MaNhaCung,TenNhaCung,DiaChi,SDT) VALUES(N'"
                + Mancctextbox.Text.Trim() + "',N'" + TenncctextBox.Text.Trim() +"',N'" + diachitextbox.Text.Trim() + "',N'" + sdttextBox.Text + "')";

            Functions.Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            deletebutton.Enabled = true;
            addbutton.Enabled = true;
            fixbutton.Enabled = true;
            savebutton.Enabled = false;
            Mancctextbox.Enabled = false;
        }
        private void fixbutton_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Mancctextbox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mancctextbox.Focus();
                return;
            }
            if (TenncctextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TenncctextBox.Focus();
                return;
            }
            if (diachitextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TenncctextBox.Focus();
                return;
            }
            sql = "UPDATE NhaCungCap SET TenNhaCung=N'" + TenncctextBox.Text.Trim().ToString() +
                "',SDT=" + sdttextBox.Text +
                ",DiaChi='" + diachitextbox.Text + "' WHERE MaNhaCung=N'" + Mancctextbox.Text + "'";
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
            if (Mancctextbox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhaCungCap WHERE MaNhaCung=N'" + Mancctextbox.Text + "'";
                Functions.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void Fm_NhaCungCap_Load_1(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from NhaCungCap";
            Mancctextbox.Enabled = false;
            savebutton.Enabled = false;

            LoadDataGridView();
            ResetValues();
        }
    }
}
