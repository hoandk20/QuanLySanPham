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
    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
        }

        private void FrmProvider_Load(object sender, EventArgs e)
        {
            show();
        }
        void show()
        {
            dataGridView1.Rows.Clear();
            //lay data tu DAO va hien thi len gridview
            nhaccDAO nDAO = new nhaccDAO();
            List<nhacungcap> list = nDAO.getList();
            foreach (nhacungcap sp in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = sp.manhacc;
                row.Cells[1].Value = sp.tennhacc;
                row.Cells[2].Value = sp.emailnhacc;
                row.Cells[3].Value = sp.dienthoai;
                dataGridView1.Rows.Add(row);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["tennhacc"], ListSortDirection.Ascending);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtManhacc.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtTennhacc.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool checkValidText(String txt)
        {
            if (txt.Trim().Length == 0 || txt.Trim().Length > 40)
            {
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string tennhacc= txtTennhacc.Text;
            if (checkValidText(phone) && checkValidText(email) && checkValidText(tennhacc))
            {
            }
            else
            {
                MessageBox.Show("Can not be blank or too loong! (không thể bỏ trống hoặc quá dài!)", "notice");
                return;

            }
            nhacungcap n = new nhacungcap();
            n.dienthoai = phone;
            n.emailnhacc = email;
            n.tennhacc = tennhacc;
            //goi DAO va them vao database
            nhaccDAO nDAO = new nhaccDAO();
            nDAO.insert(n);
            MessageBox.Show("Add successfull");
            show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //hien thong tin len text box khi click vao
                txtManhacc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTennhacc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //goi DAO va xoa hang dua theo id
                int manhacc = Convert.ToInt32(txtManhacc.Text);
                nhaccDAO sDAO = new nhaccDAO();
                if (sDAO.remove(manhacc))
                {
                    MessageBox.Show("Remove successfull!");
                    show();
                }
                else
                {
                    MessageBox.Show("Can not remove because have alot product of this provider!\n" +
                        "(Không thể xóa vì có nhiều sản phẩm thuộc nhà cung cấp này.)");
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show("invalid data input!(dữ liệu nhập sai)");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                int manhacc = Convert.ToInt32(txtManhacc.Text);
                string email = txtEmail.Text.Trim();
                string sdt = txtPhone.Text.Trim();
                string tennhacc = txtTennhacc.Text.Trim();
                if (checkValidText(sdt) && checkValidText(email) && checkValidText(tennhacc))
                {
                }
                else
                {
                    MessageBox.Show("Can not be blank or too loong! (không thể bỏ trống hoặc quá dài!)", "notice");
                    return;

                }
                //edit san pham  
                nhaccDAO nDAO = new nhaccDAO();
                nhacungcap n = new nhacungcap();
                n.manhacc = manhacc;
                n.emailnhacc = email;
                n.dienthoai = sdt;
                n.tennhacc = tennhacc;
                nDAO.edit(n);
                MessageBox.Show("Successfull  edit nhacc : " + tennhacc, "notice");
                show();
            }
            catch
            {
                MessageBox.Show("invalid data input(dữ liệu nhập sai)");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchProvider f = new FrmSearchProvider();
            f.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_MultiSelectChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
