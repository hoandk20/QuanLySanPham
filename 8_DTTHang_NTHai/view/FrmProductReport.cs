using _8_DTTHang_NTHai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_DTTHang_NTHai.view
{
    public partial class FrmProductReport : Form
    {
        private dangnhap user;

        public FrmProductReport()
        {
            InitializeComponent();
        }

        public FrmProductReport(dangnhap user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmProductReport_Load(object sender, EventArgs e)
        {
            show();
            getdateNow();
            txtName.Text = user.username;
        }
        //lay ngay hien tai
        void getdateNow()
        {
            DateTime d = DateTime.Now;
            string txt = txtdate.Text + d.ToString("dd/MM/yyyy");
            txtdate.Text = txt;
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
    }
}
