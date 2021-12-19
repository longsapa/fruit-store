using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuayHoaQua.Functions;
namespace QuayHoaQua
{
    public partial class Fm_Main : Form
    {
        //public static string ID_USER = "";
            
        public Fm_Main()
        {
            InitializeComponent();
           // customizeDesing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_NhanVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_Khach());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_Kho());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildform(new Fm_HoaDon());
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
        
        private void button6_Click_1(object sender, EventArgs e)
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

        private void button5_Click_2(object sender, EventArgs e)
        {
            openchildform(new Fm_NhaCungCap());
        }
        //private void customizeDesing()
        //{
        //    controlpanel.Visible = false;

        //}
        //private void hidesubmenu()
        //{
        //    if (controlpanel.Visible == true)
        //       controlpanel.Visible = false;
        //}
        //private void showsubmenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hidesubmenu();
        //       subMenu.Visible = true;
        //   }
        //    else
        //        subMenu.Visible = false;
        //}


    }
}
