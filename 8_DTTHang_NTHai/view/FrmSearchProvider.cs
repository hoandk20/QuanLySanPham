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
    public partial class FrmSearchProvider : Form
    {
        public FrmSearchProvider()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            show();
            
        }
        void show()
        {
            string tennhacc = txtTennhacc.Text;
            dataGridView1.Rows.Clear();
            //lay data tu DAO va hien thi len gridview
            nhaccDAO nDAO = new nhaccDAO();
            List<nhacungcap> list = nDAO.getListSearch(tennhacc);
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
