namespace Winform_QL_LinhKien
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(137, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(152, 20);
            this.ID.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(137, 105);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 20);
            this.Password.TabIndex = 3;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(37, 187);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(136, 42);
            this.login.TabIndex = 4;
            this.login.Text = "Đăng Nhập";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(202, 187);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(136, 42);
            this.register.TabIndex = 5;
            this.register.Text = "Đăng ký";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(372, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 273);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}