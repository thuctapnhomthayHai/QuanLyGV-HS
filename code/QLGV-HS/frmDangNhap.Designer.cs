namespace QLGV_HS
{
    partial class frmDangNhap
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(142, 94);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(179, 20);
            this.txt_username.TabIndex = 0;
            // 
            // label1
            // 
<<<<<<< HEAD
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
=======
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
>>>>>>> hungdv
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(142, 149);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(179, 20);
            this.txt_pass.TabIndex = 4;
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
=======
            this.button1.BackgroundImage = global::QLGV_HS.Properties.Resources.exit_blue_square_glossy_web_icon_on_clip_art__k12900692;
            this.button1.Location = new System.Drawing.Point(54, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
>>>>>>> hungdv
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
<<<<<<< HEAD
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
=======
            this.button2.Location = new System.Drawing.Point(207, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 45);
>>>>>>> hungdv
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(488, 323);
=======
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QLGV_HS.Properties.Resources.dangnhap;
            this.ClientSize = new System.Drawing.Size(690, 406);
>>>>>>> hungdv
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}