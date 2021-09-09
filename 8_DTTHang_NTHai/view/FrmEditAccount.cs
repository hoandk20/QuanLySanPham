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
    public partial class FrmEditAccount : Form
    {
        public FrmEditAccount()
        {
            InitializeComponent();
        }


        bool checkDuplicate(string name)
        {
            dangnhap d = new dangnhap();
            dangnhapDAO dDAO = new dangnhapDAO();
            d = dDAO.getuser(name);
            if (d != null)
            {
                //neu da ton tai account cung ten
                return false;
            }
            return true;
        }
        bool checkValidText(String txt)
        {
            if (txt.Trim().Length == 0 || txt.Trim().Length > 40)
            {
                return false;
            }

            return true;
        }
        private void FrmEditAccount_Load(object sender, EventArgs e)
        {
            show();
        }
        //show data to gridview
        void show()
        {
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            dangnhapDAO dDAO = new dangnhapDAO();
            List<dangnhap> d = dDAO.getList();
            dataGridView1.DataSource = d;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //su kien click vao grid view
            try
            {
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().Trim().Equals("active")){
                    //active
                    comboBox2.SelectedIndex = 0;
                }
                else
                {
                    //deactive
                    comboBox2.SelectedIndex = 1;
                }
                
                comboBox1.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            }
            catch
            {

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string fullname = txtFullName.Text;
            int mod = comboBox1.SelectedIndex;
            string state = comboBox2.Text;
            //neu thong tin dang nhap la hop le

            if (checkValidText(name) && checkValidText(pass) & checkValidText(email) && checkValidText(fullname))
            {
               
                //neu khong trung edit
                dangnhap d = new dangnhap();
                d.username = name;
                d.password = pass;
                d.email = email;
                d.fullname = fullname;
                d.mod = mod;
                d.state = state;
                //goi DAO va edit
                dangnhapDAO dDAO = new dangnhapDAO();
                dDAO.edit(d);

                

                MessageBox.Show("Successfully!", "notice");
                show();
                return;
            }
            //neu khong hop le
            else
            {
                MessageBox.Show("in valid data", "notice");
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            dangnhapDAO dDAO = new dangnhapDAO();
            dDAO.remove(txtUserName.Text);
            MessageBox.Show("Successfully!", "notice");
            show();
        }
    }
}
