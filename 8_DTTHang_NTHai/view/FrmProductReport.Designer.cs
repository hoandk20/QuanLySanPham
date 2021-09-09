
namespace _8_DTTHang_NTHai.view
{
    partial class FrmProductReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Độc lập - Tự do - Hạnh phúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.hangsp,
            this.manhacc});
            this.dataGridView1.Location = new System.Drawing.Point(53, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 359);
            this.dataGridView1.TabIndex = 4;
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
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(795, 540);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(97, 18);
            this.txtdate.TabIndex = 6;
            this.txtdate.Text = "Hà Nội, ngày ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(837, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nguời làm báo cáo";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(885, 623);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(18, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "u";
            // 
            // FrmProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 739);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmProductReport";
            this.Text = "FrmProductReport";
            this.Load += new System.EventHandler(this.FrmProductReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacc;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtName;
    }
}