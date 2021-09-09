
namespace _8_DTTHang_NTHai.view
{
    partial class FrmProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthangsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(27, 394);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(46, 17);
            this.txt.TabIndex = 1;
            this.txt.Text = "Mã sp";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(80, 394);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(133, 22);
            this.txtmasp.TabIndex = 2;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(300, 397);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(133, 22);
            this.txttensp.TabIndex = 4;
            // 
            // txtt
            // 
            this.txtt.AutoSize = true;
            this.txtt.Location = new System.Drawing.Point(247, 397);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(52, 17);
            this.txtt.TabIndex = 3;
            this.txtt.Text = "Tên sp";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(536, 397);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(133, 22);
            this.txtsoluong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "số lượng";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(763, 397);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(133, 22);
            this.txtdongia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đơn giá (k)";
            // 
            // txthangsp
            // 
            this.txthangsp.Location = new System.Drawing.Point(94, 455);
            this.txthangsp.Name = "txthangsp";
            this.txthangsp.Size = new System.Drawing.Size(133, 22);
            this.txthangsp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hãng sp";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã ncc";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 514);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 47);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 514);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 47);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(276, 514);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 47);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(835, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 34);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(396, 514);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 47);
            this.btnSort.TabIndex = 17;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(510, 514);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 47);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(619, 514);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 47);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 603);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txthangsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacc;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label txtt;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthangsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
    }
}