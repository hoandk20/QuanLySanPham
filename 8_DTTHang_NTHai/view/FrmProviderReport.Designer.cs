
namespace _8_DTTHang_NTHai.view
{
    partial class FrmProviderReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhacc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Độc lập - Tự do - Hạnh phúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhacc,
            this.tennhacc,
            this.email,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(240, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 409);
            this.dataGridView1.TabIndex = 7;
            // 
            // manhacc
            // 
            this.manhacc.HeaderText = "Mã nhà cc";
            this.manhacc.MinimumWidth = 6;
            this.manhacc.Name = "manhacc";
            this.manhacc.Width = 80;
            // 
            // tennhacc
            // 
            this.tennhacc.HeaderText = "Tên nhà cc";
            this.tennhacc.MinimumWidth = 6;
            this.tennhacc.Name = "tennhacc";
            this.tennhacc.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(955, 726);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(18, 20);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "u";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nguời làm báo cáo";
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(860, 639);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(97, 18);
            this.txtdate.TabIndex = 9;
            this.txtdate.Text = "Hà Nội, ngày ";
            // 
            // FrmProviderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 755);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmProviderReport";
            this.Text = "FrmProviderReport";
            this.Load += new System.EventHandler(this.FrmProviderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtdate;
    }
}