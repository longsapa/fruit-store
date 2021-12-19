
namespace QuayHoaQua
{
    partial class Fm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_NhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChucVuTextBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Passtextbox = new System.Windows.Forms.TextBox();
            this.mtbngaysinh = new System.Windows.Forms.DateTimePicker();
            this.mtbdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDataSet = new QuayHoaQua.BanHangDataSet();
            this.btadd = new System.Windows.Forms.Button();
            this.btfix = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new QuayHoaQua.BanHangDataSetTableAdapters.NhanVienTableAdapter();
            this.banHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKHoaDonNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new QuayHoaQua.BanHangDataSetTableAdapters.HoaDonTableAdapter();
            this.banHangDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.savebt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHoaDonNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(442, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(442, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(442, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ChucVuTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Passtextbox);
            this.panel1.Controls.Add(this.mtbngaysinh);
            this.panel1.Controls.Add(this.mtbdienthoai);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.cbbgioitinh);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtmanhanvien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 180);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ChucVuTextBox
            // 
            this.ChucVuTextBox.FormattingEnabled = true;
            this.ChucVuTextBox.Items.AddRange(new object[] {
            "Manager",
            "Warehouse Staff",
            "Sale"});
            this.ChucVuTextBox.Location = new System.Drawing.Point(134, 152);
            this.ChucVuTextBox.Name = "ChucVuTextBox";
            this.ChucVuTextBox.Size = new System.Drawing.Size(214, 21);
            this.ChucVuTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chức Vụ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(442, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mật Khẩu";
            // 
            // Passtextbox
            // 
            this.Passtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Passtextbox.Location = new System.Drawing.Point(576, 148);
            this.Passtextbox.Name = "Passtextbox";
            this.Passtextbox.Size = new System.Drawing.Size(194, 20);
            this.Passtextbox.TabIndex = 15;
            // 
            // mtbngaysinh
            // 
            this.mtbngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mtbngaysinh.Location = new System.Drawing.Point(576, 110);
            this.mtbngaysinh.Name = "mtbngaysinh";
            this.mtbngaysinh.Size = new System.Drawing.Size(194, 20);
            this.mtbngaysinh.TabIndex = 14;
            // 
            // mtbdienthoai
            // 
            this.mtbdienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbdienthoai.Location = new System.Drawing.Point(576, 62);
            this.mtbdienthoai.Name = "mtbdienthoai";
            this.mtbdienthoai.Size = new System.Drawing.Size(193, 20);
            this.mtbdienthoai.TabIndex = 12;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiachi.Location = new System.Drawing.Point(576, 19);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(194, 20);
            this.txtdiachi.TabIndex = 9;
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbgioitinh.Location = new System.Drawing.Point(134, 111);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(214, 21);
            this.cbbgioitinh.TabIndex = 8;
            this.cbbgioitinh.SelectedIndexChanged += new System.EventHandler(this.cbbgioitinh_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(134, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(134, 16);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(214, 20);
            this.txtmanhanvien.TabIndex = 6;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.banHangDataSet;
            // 
            // banHangDataSet
            // 
            this.banHangDataSet.DataSetName = "BanHangDataSet";
            this.banHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btadd
            // 
            this.btadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btadd.BackColor = System.Drawing.Color.Transparent;
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(618, 24);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(152, 51);
            this.btadd.TabIndex = 8;
            this.btadd.Text = "Thêm   ";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click_1);
            // 
            // btfix
            // 
            this.btfix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btfix.BackColor = System.Drawing.Color.Transparent;
            this.btfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfix.Image = ((System.Drawing.Image)(resources.GetObject("btfix.Image")));
            this.btfix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfix.Location = new System.Drawing.Point(16, 24);
            this.btfix.Name = "btfix";
            this.btfix.Size = new System.Drawing.Size(152, 51);
            this.btfix.TabIndex = 9;
            this.btfix.Text = "Sửa    ";
            this.btfix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfix.UseVisualStyleBackColor = false;
            this.btfix.Click += new System.EventHandler(this.btfix_Click);
            // 
            // btdelete
            // 
            this.btdelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btdelete.BackColor = System.Drawing.Color.Transparent;
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(217, 24);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(152, 51);
            this.btdelete.TabIndex = 10;
            this.btdelete.Text = "Xóa    ";
            this.btdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // banHangDataSetBindingSource
            // 
            this.banHangDataSetBindingSource.DataSource = this.banHangDataSet;
            this.banHangDataSetBindingSource.Position = 0;
            // 
            // fKHoaDonNhanVienBindingSource
            // 
            this.fKHoaDonNhanVienBindingSource.DataMember = "FK_HoaDon_NhanVien";
            this.fKHoaDonNhanVienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // banHangDataSetBindingSource1
            // 
            this.banHangDataSetBindingSource1.DataSource = this.banHangDataSet;
            this.banHangDataSetBindingSource1.Position = 0;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.banHangDataSetBindingSource1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 185);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // savebt
            // 
            this.savebt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savebt.BackColor = System.Drawing.Color.Transparent;
            this.savebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebt.Image = ((System.Drawing.Image)(resources.GetObject("savebt.Image")));
            this.savebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebt.Location = new System.Drawing.Point(423, 24);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(151, 51);
            this.savebt.TabIndex = 12;
            this.savebt.Text = "Lưu    ";
            this.savebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebt.UseVisualStyleBackColor = false;
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btadd);
            this.panel2.Controls.Add(this.savebt);
            this.panel2.Controls.Add(this.btfix);
            this.panel2.Controls.Add(this.btdelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 13;
            // 
            // Fm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Fm_NhanVien";
            this.Text = "Fm_NhanVien1";
            this.Load += new System.EventHandler(this.Fm_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHoaDonNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btfix;
        private System.Windows.Forms.Button btdelete;
        private BanHangDataSet banHangDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private BanHangDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource banHangDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKHoaDonNhanVienBindingSource;
        private BanHangDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.BindingSource banHangDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox mtbdienthoai;
        private System.Windows.Forms.DateTimePicker mtbngaysinh;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Passtextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ChucVuTextBox;
    }
}