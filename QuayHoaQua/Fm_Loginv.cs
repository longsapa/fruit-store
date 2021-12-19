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
using System.Collections.Generic;
using QuayHoaQua.Functions;
namespace QuayHoaQua
{
    public partial class Fm_Loginv : Form
    {
        private SqlConnection  Con;
        public Fm_Loginv()
        {
            InitializeComponent();
        }
        public static string ID_USER = "";
        private void button1_Click(object sender, EventArgs e)
        {
            ID_USER = Functions.Functions.GetID(UserTextBox.Text, PasswordTextBox.Text , PositionComboBox.Text);
            if (ID_USER != "")
            {
                if(PositionComboBox.SelectedItem == "Manager")
                {
                    Fm_Main fmain = new Fm_Main();
                    fmain.Show();
                    this.Hide();
                }
                else if(PositionComboBox.SelectedItem == "Warehouse Staff")
                {
                    Fm_Main_warehouse fmain = new Fm_Main_warehouse();
                    fmain.Show();
                    this.Hide();
                }    
                else
                {
                    Fm_MainStaff fmain = new Fm_MainStaff();
                    fmain.Show();
                    this.Hide();
                }
            }
            
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng , check lại chức vụ của mình nhé !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
