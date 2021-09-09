using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_DTTHang_NTHai.DAO;

namespace _8_DTTHang_NTHai.view
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }
        dangnhap user;
        public FrmMain(dangnhap name)
        {
            InitializeComponent();
            Name = name.username;
            this.Text = name.username;
            this.user = name;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //neu la user thi an system
            if (user.mod == 0)
            {
                accountManageToolStripMenuItem.Visible = false;
            }
            //neu la admin thi hien  system
            if(user.mod == 1)
            {
                accountManageToolStripMenuItem.Visible = true;
            }
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddAccount f = new FrmAddAccount();
            f.MdiParent = this;
            f.Show();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditAccount f = new FrmEditAccount();
            f.MdiParent = this;
            f.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Visible = true;
            this.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts f = new FrmProducts();
            f.MdiParent = this;
            f.Show();
        }

        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo words
            try
            {
                string outfile = "\"C:\\Users\\hp\\Desktop\\New folder (4)\\outFile.doc\"";
                Process.Start("WINWORD.EXE", outfile);
            }
            catch
            {
                MessageBox.Show("can not find the app!", "notice");
            }
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo paint
            try
            {
                Process.Start("mspaint");
            }
            catch
            {
                MessageBox.Show("can not find the app!", "notice");
            }
            
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo exel
            try
            {
                string myPath = @"C:\Users\Lenovo\Documents\MyFile.xlsx";
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "excel"; // "EXCEL.EXE" also works
                ps.Arguments = myPath;
                ps.UseShellExecute = true;
                Process.Start(ps);
            }
            catch
            {
                MessageBox.Show("can not find the app!", "notice");
            }
        }

        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm số 08:\n" +
                " 1: Dư Thị Thu Hằng, MSV:1710300064, ngày sinh: 23/2/1999, duthuhang99@gmail.com\n" +
                "2: Nguyễn Thanh Hải   MSV: 17103100093, ngày sinh: 24 / 11 / 1999, hainguyen.1724@gmail.com");
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu bạn là Admin thì có thể vào phần System>Account manage để quản lí tài khoản.\n" +
                "Vào Manage để quản lí sản phẩm và nhà cung cấp\n" +
                "Vào Report để xem các báo cáo về sản phẩm và nhà cung cấp\n" +
                "Vào Utilities để mở các ứng dụng tiện ích.\n" +
                "Vào Help để xem hướng dẫn, tác giả, bản quyền\n" +
                "Ấn Exit để thoát");
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChangePassword f = new FrmChangePassword(user);
            f.MdiParent = this;
            f.Show();
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvider f = new FrmProvider();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductReport f = new FrmProductReport(user);
            f.MdiParent = this;
            f.Show();
        }

        private void providersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProviderReport f = new FrmProviderReport(user);
            f.MdiParent = this;
            f.Show();
        }
    }
}
