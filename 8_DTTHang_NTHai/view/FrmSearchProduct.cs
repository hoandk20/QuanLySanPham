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
    public partial class FrmSearchProduct : Form
    {
        public FrmSearchProduct()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            show();

        }

        void show()
        {
            dataGridView1.Rows.Clear();
            //lay data tu DAO va hien thi len gridview
            string tensp = txttensp.Text.Trim();
            string hangsp = txthangsp.Text.Trim();
            List<sanpham> list = new List<sanpham>();
            if (checkValidText(tensp) | checkValidText(hangsp))
            {//neu chuoi nhap vao hop le thi hien thi ket qua

                //neu nhap ca 2
                if (tensp.Length == 0 && hangsp.Length == 0)
                {
                    sanphamDAO sDAO = new sanphamDAO();
                     list= sDAO.getListSearch(tensp, hangsp);
                }
                //neu chi nhap ten  sp
                if (tensp.Length != 0&&hangsp.Length==0)
                {
                    sanphamDAO sDAO = new sanphamDAO();
                    list = sDAO.getListTensp(tensp);
                }
                //neu chi nhap hang sp
                if (tensp.Length == 0 && hangsp.Length != 0)
                {
                    sanphamDAO sDAO = new sanphamDAO();
                    list = sDAO.getListHangsp( hangsp);
                }

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
            else
            {
                MessageBox.Show("can not be blank!", "notice");
            }
            
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {

        }
        //kiem tra neu chuoi nhap vao rong hoac qua dai
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
