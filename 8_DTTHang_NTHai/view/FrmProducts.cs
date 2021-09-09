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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            loadMaNhacc();     
            show();
        }
        //load manhacc vao grid view
        void loadMaNhacc()
        {
            nhaccDAO dDAO = new nhaccDAO();
            List<nhacungcap> list = dDAO.getList();
            foreach(nhacungcap n in list)
            {
                comboBox1.Items.Add(n.manhacc);
            }
        }
        void show()
        {

            dataGridView1.Rows.Clear();
            //lay data tu DAO va hien thi len gridview
            sanphamDAO pDAO = new sanphamDAO();
            List<sanpham> list = pDAO.getList();
            
            foreach (sanpham sp in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = sp.masp;
                row.Cells[1].Value = sp.tensp;
                row.Cells[2].Value = sp.soluong;
                row.Cells[3].Value = sp.dongia;
                row.Cells[4].Value = sp.thanhtien;
                row.Cells[5].Value = sp.hangsp;
                row.Cells[6].Value = sp.manhacc;
                dataGridView1.Rows.Add(row);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //hien thong tin len text box khi click vao
                txtmasp.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txttensp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtdongia.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txthangsp.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                comboBox1.SelectedItem = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString().Trim());
            }
            catch
            {

            }
            
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

            sanphamDAO sDAO = new sanphamDAO();
            sanpham s = new sanpham();
            try
            {


                //neu bo trong hoac qua dai
                if (checkValidText(txttensp.Text)&&checkValidText(txthangsp.Text))
                {

                }
                else
                {
                    MessageBox.Show("Can not be blank or too loong! (không thể bỏ trống hoặc quá dài!)", "notice");
                    return;
                }
                //add san pham vao database
                s.tensp = txttensp.Text;
                    int sl = Convert.ToInt32(txtsoluong.Text);
                    s.soluong = sl;
                    double dg = Convert.ToDouble(txtdongia.Text);
                    s.dongia = dg;
                    double thanhtien = sl * dg;
                    s.thanhtien = thanhtien;
                    s.hangsp = txthangsp.Text;
                    int manhacc =Convert.ToInt32(comboBox1.SelectedItem.ToString().Trim());
                    s.manhacc = manhacc;
                    
                    sDAO.insert(s);
                    MessageBox.Show("Successfull add:" + txttensp.Text, "notice");
                    show();
               
            }
            catch
            {
                MessageBox.Show("invalid data input(dữ liệu nhập sai)");
            }
            


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sanphamDAO sDAO = new sanphamDAO();
            sanpham s = new sanpham();
            try
            {

                int masp = Convert.ToInt32(txtmasp.Text);

                //neu bo trong hoac qua dai
                if (checkValidText(txttensp.Text) && checkValidText(txthangsp.Text))
                {

                }
                else
                {
                    MessageBox.Show("Can not be blank or too loong! (không thể bỏ trống hoặc quá dài!)", "notice");
                    return;
                }
                //edit san pham  
                s.masp = masp;
                    s.tensp = txttensp.Text;
                    int sl = Convert.ToInt32(txtsoluong.Text);
                    s.soluong = sl;
                    double dg = Convert.ToDouble(txtdongia.Text);
                    s.dongia = dg;
                    double thanhtien = sl * dg;
                    s.thanhtien = thanhtien;
                    s.hangsp = txthangsp.Text;
                    int manhacc = Convert.ToInt32(comboBox1.SelectedItem.ToString().Trim());
                    s.manhacc = manhacc;
                    sDAO.edit(s);
                    MessageBox.Show("Successfull  edit sp:" + masp, "notice");
                    show();

               
            }
            catch
            {
                MessageBox.Show("invalid data input(dữ liệu nhập sai)");
            }

        }

        //nhan vao remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            try
            {
                int masp = Convert.ToInt32(txtmasp.Text);
                sanphamDAO sDAO = new sanphamDAO();
                sDAO.remove(masp);
                MessageBox.Show("Remove successfull!");
                show();
            }
            catch
            {
                MessageBox.Show("invalid data input(dữ liệu nhập sai)");
            }
        }

        //nhan vao sort
        private void btnSort_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["dongia"], ListSortDirection.Descending);
        }


        //an vao button reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtmasp.Text = "";
            txtdongia.Text = "";
            txthangsp.Text = "";
            txtsoluong.Text = "";
            txttensp.Text = "";
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchProduct f = new FrmSearchProduct();
            FrmMain fmain = new FrmMain();
            f.Show();
        }
    }
}
