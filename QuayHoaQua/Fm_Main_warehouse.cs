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
    public partial class Fm_Main_warehouse : Form
    {
        public Fm_Main_warehouse()
        {
            InitializeComponent();
        }

        private void kho_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_Kho());
        }
        private void NCC_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_NhaCungCap());
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
        private void midpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

            // showsubmenu(controlpanel);

        }

        private void exit_button(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn rằng muốn thoát ?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Functions.Functions.Disconnect(); //Đóng kết nối
                Application.Exit(); //Thoát
            }
        }

        private void Fm_load(object sender, EventArgs e)
        {
            Functions.Functions.Connect();

        }
    }
}
