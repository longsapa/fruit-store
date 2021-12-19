
namespace QuayHoaQua
{
    partial class Fm_khachStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_khachStaff));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diachitextBox = new System.Windows.Forms.TextBox();
            this.tenkhachtextBox = new System.Windows.Forms.TextBox();
            this.makhachtextBox = new System.Windows.Forms.TextBox();
            this.dienthoailabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDataSet = new QuayHoaQua.BanHangDataSet();
            this.dienthoaimaskedTextBox = new System.Windows.Forms.TextBox();
            this.diachilabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.khachTableAdapter = new QuayHoaQua.BanHangDataSetTableAdapters.KhachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // diachitextBox
            // 
            this.diachitextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.diachitextBox.Location = new System.Drawing.Point(560, 40);
            this.diachitextBox.Name = "diachitextBox";
            this.diachitextBox.Size = new System.Drawing.Size(203, 20);
            this.diachitextBox.TabIndex = 21;
            // 
            // tenkhachtextBox
            // 
            this.tenkhachtextBox.Location = new System.Drawing.Point(187, 92);
            this.tenkhachtextBox.Name = "tenkhachtextBox";
            this.tenkhachtextBox.Size = new System.Drawing.Size(194, 20);
            this.tenkhachtextBox.TabIndex = 20;
            // 
            // makhachtextBox
            // 
            this.makhachtextBox.Location = new System.Drawing.Point(187, 45);
            this.makhachtextBox.Name = "makhachtextBox";
            this.makhachtextBox.Size = new System.Drawing.Size(194, 20);
            this.makhachtextBox.TabIndex = 19;
            // 
            // dienthoailabel
            // 
            this.dienthoailabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dienthoailabel.AutoSize = true;
            this.dienthoailabel.BackColor = System.Drawing.Color.Transparent;
            this.dienthoailabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienthoailabel.ForeColor = System.Drawing.Color.Black;
            this.dienthoailabel.Location = new System.Drawing.Point(449, 92);
            this.dienthoailabel.Name = "dienthoailabel";
            this.dienthoailabel.Size = new System.Drawing.Size(95, 20);
            this.dienthoailabel.TabIndex = 18;
            this.dienthoailabel.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Khách";
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataMember = "Khach";
            this.khachBindingSource.DataSource = this.banHangDataSet;
            // 
            // banHangDataSet
            // 
            this.banHangDataSet.DataSetName = "BanHangDataSet";
            this.banHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dienthoaimaskedTextBox
            // 
            this.dienthoaimaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dienthoaimaskedTextBox.Location = new System.Drawing.Point(560, 92);
            this.dienthoaimaskedTextBox.Name = "dienthoaimaskedTextBox";
            this.dienthoaimaskedTextBox.Size = new System.Drawing.Size(203, 20);
            this.dienthoaimaskedTextBox.TabIndex = 26;
            // 
            // diachilabel
            // 
            this.diachilabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.diachilabel.AutoSize = true;
            this.diachilabel.BackColor = System.Drawing.Color.Transparent;
            this.diachilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachilabel.ForeColor = System.Drawing.Color.Black;
            this.diachilabel.Location = new System.Drawing.Point(449, 43);
            this.diachilabel.Name = "diachilabel";
            this.diachilabel.Size = new System.Drawing.Size(67, 20);
            this.diachilabel.TabIndex = 25;
            this.diachilabel.Text = "Địa Chỉ";
            // 
            // savebutton
            // 
            this.savebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savebutton.BackColor = System.Drawing.Color.White;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.Black;
            this.savebutton.Image = ((System.Drawing.Image)(resources.GetObject("savebutton.Image")));
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.Location = new System.Drawing.Point(614, 349);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(119, 61);
            this.savebutton.TabIndex = 24;
            this.savebutton.Text = "Lưu    ";
            this.savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addbutton.BackColor = System.Drawing.Color.White;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.Black;
            this.addbutton.Image = ((System.Drawing.Image)(resources.GetObject("addbutton.Image")));
            this.addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbutton.Location = new System.Drawing.Point(50, 349);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(119, 61);
            this.addbutton.TabIndex = 23;
            this.addbutton.Text = "Thêm";
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // khachTableAdapter
            // 
            this.khachTableAdapter.ClearBeforeFill = true;
            // 
            // Fm_khachStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diachitextBox);
            this.Controls.Add(this.tenkhachtextBox);
            this.Controls.Add(this.makhachtextBox);
            this.Controls.Add(this.dienthoailabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dienthoaimaskedTextBox);
            this.Controls.Add(this.diachilabel);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addbutton);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Fm_khachStaff";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fm_khachStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox diachitextBox;
        private System.Windows.Forms.TextBox tenkhachtextBox;
        private System.Windows.Forms.TextBox makhachtextBox;
        private System.Windows.Forms.Label dienthoailabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khachBindingSource;
        private BanHangDataSet banHangDataSet;
        private System.Windows.Forms.TextBox dienthoaimaskedTextBox;
        private System.Windows.Forms.Label diachilabel;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button addbutton;
        private BanHangDataSetTableAdapters.KhachTableAdapter khachTableAdapter;
    }
}