
namespace QuayHoaQua
{
    partial class Fm_Main_warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Main_warehouse));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logopanel = new System.Windows.Forms.Panel();
            this.midpanel = new System.Windows.Forms.Panel();
            this.mainpanel.SuspendLayout();
            this.controlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.AutoScroll = true;
            this.mainpanel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainpanel.Controls.Add(this.button6);
            this.mainpanel.Controls.Add(this.controlpanel);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.logopanel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(200, 614);
            this.mainpanel.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Thoát ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.exit_button);
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.Azure;
            this.controlpanel.Controls.Add(this.button5);
            this.controlpanel.Controls.Add(this.button3);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 172);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(200, 75);
            this.controlpanel.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 36);
            this.button5.TabIndex = 3;
            this.button5.Text = "Nhà Cung Cấp";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NCC_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kho hàng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.kho_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Design : Nguyễn Thăng Long\r\n                Cao Văn Minh\r\n                Nguyễn " +
    "Quang Nhật";
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.PeachPuff;
            this.logopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logopanel.BackgroundImage")));
            this.logopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(200, 172);
            this.logopanel.TabIndex = 0;
            // 
            // midpanel
            // 
            this.midpanel.AutoSize = true;
            this.midpanel.BackColor = System.Drawing.Color.Transparent;
            this.midpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("midpanel.BackgroundImage")));
            this.midpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.midpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midpanel.Location = new System.Drawing.Point(200, 0);
            this.midpanel.Name = "midpanel";
            this.midpanel.Size = new System.Drawing.Size(878, 614);
            this.midpanel.TabIndex = 3;
            // 
            // Fm_Main_warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 614);
            this.Controls.Add(this.midpanel);
            this.Controls.Add(this.mainpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fm_Main_warehouse";
            this.Text = "Quản lý kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.controlpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel midpanel;
    }
}