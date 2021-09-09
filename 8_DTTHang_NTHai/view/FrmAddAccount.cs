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
    public partial class FrmAddAccount : Form
    {
        public FrmAddAccount()
        {
            InitializeComponent();
        }

        private void FrmAddAccount_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string fullname = txtFullName.Text;
            int mod = comboBox1.SelectedIndex;
            //neu thong tin dang nhap la hop le
            
            if (checkValidText(name) && checkValidText(pass) & checkValidText(email) && checkValidText(fullname))
            {
                //neu da ton tai username
                if (!checkDuplicate(name))
                {
                    MessageBox.Show("Duplicate username !", "notice");
                    return;
                }
                dangnhap d = new dangnhap();
                d.username = name;
                d.password = pass;
                d.email = email;
                d.fullname = fullname;
                d.mod = mod;
                d.state = "active";
                //goi DAO va them account
                dangnhapDAO dDAO = new dangnhapDAO();
                dDAO.insert(d);


                txtEmail.Text = "";
                txtPass.Text = "";
                txtFullName.Text = "";
                txtName.Text = "";
                MessageBox.Show("Successfully!", "notice");
                return;
            }
            //neu khong hop le
            else
            {
                MessageBox.Show("in valid data", "notice");
                return;
            }
            

        }
        //kiem tra trung ten tai khoan
        bool checkDuplicate(string name)
        {
            dangnhap d = new dangnhap();
            dangnhapDAO dDAO = new dangnhapDAO();
            d =dDAO.getuser(name);
            if (d != null)
            {
                //neu da ton tai account cung ten
                return false;
            }
            return true;
        }
        //kiem tra chuoi hop le
        bool checkValidText(String txt)
        {
            if (txt.Trim().Length == 0 || txt.Trim().Length > 40)
            {
                return false;
            }

            return true;
        }
    }
}
