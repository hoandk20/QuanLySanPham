using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_DTTHang_NTHai.DAO;

namespace _8_DTTHang_NTHai.view
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        dangnhap d;
        public FrmChangePassword(dangnhap d)
        {
            this.d = d;
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtname.Text = d.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Can not be blank (không thể bỏ trống)!", "notice");
            }
            //neu password giong voi confirmpassword 
            if (txtpass.Text.Equals(txtConfirmPass.Text))
            {
                d.password = txtConfirmPass.Text;
                //goi DAO va lay ra mat khau de so sanh
                dangnhapDAO dDAO = new dangnhapDAO();
                dangnhap check = dDAO.getuser(d.username);

                dDAO.edit(d);
                MessageBox.Show("successfully!","notice");
            }
            else
            {
                MessageBox.Show("password and confirm password not the same","notice");
            }
        }
    }
}
