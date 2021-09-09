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
    public partial class FrmProviderReport : Form
    {
        private dangnhap user;

        public FrmProviderReport()
        {
            InitializeComponent();
        }
        public FrmProviderReport(dangnhap user)
        {
            InitializeComponent();
            this.user = user;
        }
        void getdateNow()
        {
            DateTime d = DateTime.Now;
            string txt = txtdate.Text + d.ToString("dd/MM/yyyy");
            txtdate.Text = txt;
        }
        private void FrmProviderReport_Load(object sender, EventArgs e)
        {
            
            getdateNow();
            txtName.Text = user.username;
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
    }
}
