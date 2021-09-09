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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;
            //neu du lieu nhap vao trong
            if(name.Trim().Length==0|| pass.Trim().Length == 0)
            {
                MessageBox.Show("can not be blank!(không thể bỏ trống)", "notice");
                return;
            }
            else
            {
                //lay account tu database
                dangnhapDAO DAO = new dangnhapDAO();
                dangnhap user = DAO.getuser(name, pass);
                
                if (user != null)
                {
                    if (user.state.Trim().Equals("deactive"))
                    {
                        MessageBox.Show("Your account has been deative!(tài khoản của bạn bị khóa)", "notice");
                        return;
                    }
                    //dang nhap thanh cong
                    MessageBox.Show("login successfull!", "notice");
                    //truyen user vao formMain
                    FrmMain f = new FrmMain(user);
                    this.Hide();
                    f.Visible = true;
                    f.AutoSize = true;

                }
                else
                {
                    //neu sau mat khau hoac ko ton tai account
                    MessageBox.Show("wrong username of password!", "notice");
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
