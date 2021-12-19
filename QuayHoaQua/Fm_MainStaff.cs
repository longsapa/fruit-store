using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuayHoaQua
{
    public partial class Fm_MainStaff : Form
    {
        public Fm_MainStaff()
        {
            InitializeComponent();
        }
        private void Fm_load(object sender, EventArgs e)
        {
            Functions.Functions.Connect();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_khachStaff());
        }
        private Form activeForm = null;
        private void openchildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            midpanel.Controls.Add(childForm);
            midpanel.Tag = midpanel;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_HoaDonStaff());
        }
        private void button6_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn rằng muốn thoát ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Functions.Functions.Disconnect(); //Đóng kết nối
                Application.Exit(); //Thoát
            }
        }
    }
}
