namespace QLGV_HS
{
    partial class frmGiaoVien
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
            this.lbma = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbgt = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbluong = new System.Windows.Forms.Label();
            this.lbmamon = new System.Windows.Forms.Label();
            this.lbns = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbma.Location = new System.Drawing.Point(102, 24);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(54, 16);
            this.lbma.TabIndex = 0;
            this.lbma.Text = "Mã GV";
            this.lbma.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(102, 90);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(60, 16);
            this.lbten.TabIndex = 1;
            this.lbten.Text = "Tên GV";
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgt.Location = new System.Drawing.Point(102, 156);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(64, 16);
            this.lbgt.TabIndex = 2;
            this.lbgt.Text = "Giới tính";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.Location = new System.Drawing.Point(360, 25);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(99, 16);
            this.lbsdt.TabIndex = 3;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // lbluong
            // 
            this.lbluong.AutoSize = true;
            this.lbluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluong.Location = new System.Drawing.Point(360, 89);
            this.lbluong.Name = "lbluong";
            this.lbluong.Size = new System.Drawing.Size(50, 16);
            this.lbluong.TabIndex = 4;
            this.lbluong.Text = "Lương";
            // 
            // lbmamon
            // 
            this.lbmamon.AutoSize = true;
            this.lbmamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmamon.Location = new System.Drawing.Point(360, 152);
            this.lbmamon.Name = "lbmamon";
            this.lbmamon.Size = new System.Drawing.Size(62, 16);
            this.lbmamon.TabIndex = 5;
            this.lbmamon.Text = "Mã môn";
            // 
            // lbns
            // 
            this.lbns.AutoSize = true;
            this.lbns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbns.Location = new System.Drawing.Point(102, 218);
            this.lbns.Name = "lbns";
            this.lbns.Size = new System.Drawing.Size(77, 16);
            this.lbns.TabIndex = 6;
            this.lbns.Text = "Ngày sinh";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(185, 24);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(185, 89);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 8;
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(185, 155);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(100, 20);
            this.txtgt.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(483, 23);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 10;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(483, 89);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 20);
            this.txtluong.TabIndex = 11;
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(483, 152);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(100, 20);
            this.txtmamon.TabIndex = 12;
            // 
            // txtns
            // 
            this.txtns.Location = new System.Drawing.Point(185, 217);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(100, 20);
            this.txtns.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(131, 264);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(311, 264);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(483, 264);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.GioiTinh,
            this.NgaySinh,
            this.SDT,
            this.Luong,
            this.MaMon});
            this.dataGridView1.Location = new System.Drawing.Point(2, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGA";
            this.MaGV.HeaderText = "Mã giáo viên";
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên giáo viên";
            this.TenGV.Name = "TenGV";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.Name = "MaMon";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.txtmamon);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.lbns);
            this.Controls.Add(this.lbmamon);
            this.Controls.Add(this.lbluong);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbgt);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.lbma);
            this.Name = "frmGiaoVien";
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbluong;
        private System.Windows.Forms.Label lbmamon;
        private System.Windows.Forms.Label lbns;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
    }
}