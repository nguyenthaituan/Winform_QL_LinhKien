namespace Winform_QL_LinhKien
{
    partial class DangKy
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
            this.Password = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(160, 76);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 20);
            this.Password.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(160, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(152, 20);
            this.ID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ và Tên:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(209, 251);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(136, 42);
            this.back.TabIndex = 15;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // complete
            // 
            this.complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete.Location = new System.Drawing.Point(44, 251);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(136, 42);
            this.complete.TabIndex = 14;
            this.complete.Text = "Đăng ký";
            this.complete.UseVisualStyleBackColor = true;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 316);
            this.Controls.Add(this.back);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button complete;
    }
}