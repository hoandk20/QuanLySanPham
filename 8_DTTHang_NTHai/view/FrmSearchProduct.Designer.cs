
namespace _8_DTTHang_NTHai.view
{
    partial class FrmSearchProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttensp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthangsp = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(219, 403);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(129, 22);
            this.txttensp.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.hangsp,
            this.manhacc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sp";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.Width = 80;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sp";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "đơn giá ( k )";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "thành tiền ( k )";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 125;
            // 
            // hangsp
            // 
            this.hangsp.HeaderText = "hãng sp";
            this.hangsp.MinimumWidth = 6;
            this.hangsp.Name = "hangsp";
            this.hangsp.Width = 125;
            // 
            // manhacc
            // 
            this.manhacc.HeaderText = "mã ncc";
            this.manhacc.MinimumWidth = 6;
            this.manhacc.Name = "manhacc";
            this.manhacc.Width = 80;
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(129, 408);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(52, 17);
            this.tx.TabIndex = 3;
            this.tx.Text = "Tên sp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "hãng sp";
            // 
            // txthangsp
            // 
            this.txthangsp.Location = new System.Drawing.Point(219, 446);
            this.txthangsp.Name = "txthangsp";
            this.txthangsp.Size = new System.Drawing.Size(129, 22);
            this.txthangsp.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(512, 423);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthangsp);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttensp);
            this.Name = "FrmSearchProduct";
            this.Text = "FrmSearchProduct";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacc;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthangsp;
        private System.Windows.Forms.Button btnSearch;
    }
}