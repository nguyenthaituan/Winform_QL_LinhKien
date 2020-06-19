namespace Winform_QL_LinhKien
{
    partial class MHChinh
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.login = new System.Windows.Forms.ToolStripLabel();
            this.userID = new System.Windows.Forms.ToolStripLabel();
            this.username = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nhanvien = new System.Windows.Forms.Button();
            this.lapDDH = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login,
            this.userID,
            this.username,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 22);
            this.login.Text = "Đăng nhập";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // userID
            // 
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(89, 22);
            this.userID.Text = "Mã người dùng";
            this.userID.Visible = false;
            // 
            // username
            // 
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(90, 22);
            this.username.Text = "Tên người dùng";
            this.username.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(11, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã LK";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên linh kiện";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại linh kiện";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tình trạng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nhà sản xuất";
            this.Column7.Name = "Column7";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Tìm kiếm";
            this.search.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại LK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "tên LK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh mục sản phẩm";
            // 
            // Nhanvien
            // 
            this.Nhanvien.Location = new System.Drawing.Point(560, 77);
            this.Nhanvien.Name = "Nhanvien";
            this.Nhanvien.Size = new System.Drawing.Size(113, 28);
            this.Nhanvien.TabIndex = 9;
            this.Nhanvien.Text = "Quản lý danh mục";
            this.Nhanvien.UseVisualStyleBackColor = true;
            // 
            // lapDDH
            // 
            this.lapDDH.Location = new System.Drawing.Point(441, 77);
            this.lapDDH.Name = "lapDDH";
            this.lapDDH.Size = new System.Drawing.Size(113, 28);
            this.lapDDH.TabIndex = 10;
            this.lapDDH.Text = "Đặt hàng";
            this.lapDDH.UseVisualStyleBackColor = true;
            this.lapDDH.Click += new System.EventHandler(this.lapDDH_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(300, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(110, 22);
            this.toolStripLabel1.Text = "Thông tin tài khoản";
            this.toolStripLabel1.Visible = false;
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // MHChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 412);
            this.Controls.Add(this.lapDDH);
            this.Controls.Add(this.Nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MHChinh";
            this.Text = " ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel login;
        private System.Windows.Forms.ToolStripLabel userID;
        private System.Windows.Forms.ToolStripLabel username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nhanvien;
        private System.Windows.Forms.Button lapDDH;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

