namespace LKMT.GUI
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDropdown = new System.Windows.Forms.Panel();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnNhomSP = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelDropdown2 = new System.Windows.Forms.Panel();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnQLKho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logocompany = new System.Windows.Forms.PictureBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelDropdown.SuspendLayout();
            this.PanelDropdown2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logocompany)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 21);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(233, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 37);
            this.panel3.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LKMT.Properties.Resources.close_window_26px;
            this.btnClose.Location = new System.Drawing.Point(1241, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::LKMT.Properties.Resources.bell;
            this.button6.Location = new System.Drawing.Point(1148, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 37);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::LKMT.Properties.Resources.minimize_window_26px;
            this.btnMinimize.Location = new System.Drawing.Point(1195, -1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 37);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PanelDropdown);
            this.flowLayoutPanel1.Controls.Add(this.btnThuongHieu);
            this.flowLayoutPanel1.Controls.Add(this.btnThanhToan);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.PanelDropdown2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 151);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 630);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // PanelDropdown
            // 
            this.PanelDropdown.Controls.Add(this.btnLoaiSP);
            this.PanelDropdown.Controls.Add(this.btnNhomSP);
            this.PanelDropdown.Controls.Add(this.btnSanPham);
            this.PanelDropdown.Controls.Add(this.btnQLSP);
            this.PanelDropdown.Location = new System.Drawing.Point(4, 4);
            this.PanelDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDropdown.MaximumSize = new System.Drawing.Size(227, 209);
            this.PanelDropdown.MinimumSize = new System.Drawing.Size(227, 63);
            this.PanelDropdown.Name = "PanelDropdown";
            this.PanelDropdown.Size = new System.Drawing.Size(227, 63);
            this.PanelDropdown.TabIndex = 11;
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.BackColor = System.Drawing.Color.Gray;
            this.btnLoaiSP.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.Location = new System.Drawing.Point(0, 161);
            this.btnLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(227, 49);
            this.btnLoaiSP.TabIndex = 4;
            this.btnLoaiSP.Text = "Loại Linh Kiện";
            this.btnLoaiSP.UseVisualStyleBackColor = false;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnNhomSP
            // 
            this.btnNhomSP.BackColor = System.Drawing.Color.Gray;
            this.btnNhomSP.FlatAppearance.BorderSize = 0;
            this.btnNhomSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhomSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhomSP.ForeColor = System.Drawing.Color.White;
            this.btnNhomSP.Location = new System.Drawing.Point(0, 112);
            this.btnNhomSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhomSP.Name = "btnNhomSP";
            this.btnNhomSP.Size = new System.Drawing.Size(228, 49);
            this.btnNhomSP.TabIndex = 3;
            this.btnNhomSP.Text = "Nhóm Linh Kiện";
            this.btnNhomSP.UseVisualStyleBackColor = false;
            this.btnNhomSP.Click += new System.EventHandler(this.btnNhomSP_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Gray;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(0, 64);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(227, 48);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Linh Kiện";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQLSP.FlatAppearance.BorderSize = 0;
            this.btnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.ForeColor = System.Drawing.Color.White;
            this.btnQLSP.Location = new System.Drawing.Point(-4, -1);
            this.btnQLSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(232, 65);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lý Linh Kiện";
            this.btnQLSP.UseVisualStyleBackColor = false;
            this.btnQLSP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThuongHieu.FlatAppearance.BorderSize = 0;
            this.btnThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuongHieu.ForeColor = System.Drawing.Color.White;
            this.btnThuongHieu.Location = new System.Drawing.Point(4, 75);
            this.btnThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(227, 62);
            this.btnThuongHieu.TabIndex = 2;
            this.btnThuongHieu.Text = "    Quản lý Thương hiệu";
            this.btnThuongHieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuongHieu.UseVisualStyleBackColor = false;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(4, 145);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(231, 62);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "    Quản lý Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "    Quản lý Khách hàng";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PanelDropdown2
            // 
            this.PanelDropdown2.Controls.Add(this.btnXuatKho);
            this.PanelDropdown2.Controls.Add(this.btnNhapKho);
            this.PanelDropdown2.Controls.Add(this.btnQLKho);
            this.PanelDropdown2.Location = new System.Drawing.Point(4, 285);
            this.PanelDropdown2.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDropdown2.MaximumSize = new System.Drawing.Size(227, 164);
            this.PanelDropdown2.MinimumSize = new System.Drawing.Size(227, 64);
            this.PanelDropdown2.Name = "PanelDropdown2";
            this.PanelDropdown2.Size = new System.Drawing.Size(227, 64);
            this.PanelDropdown2.TabIndex = 12;
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.BackColor = System.Drawing.Color.Gray;
            this.btnXuatKho.FlatAppearance.BorderSize = 0;
            this.btnXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKho.ForeColor = System.Drawing.Color.White;
            this.btnXuatKho.Location = new System.Drawing.Point(0, 112);
            this.btnXuatKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(228, 49);
            this.btnXuatKho.TabIndex = 3;
            this.btnXuatKho.Text = "Xuất kho";
            this.btnXuatKho.UseVisualStyleBackColor = false;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.Gray;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 64);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(227, 48);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnQLKho
            // 
            this.btnQLKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQLKho.FlatAppearance.BorderSize = 0;
            this.btnQLKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKho.ForeColor = System.Drawing.Color.White;
            this.btnQLKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKho.Location = new System.Drawing.Point(-4, 0);
            this.btnQLKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.Size = new System.Drawing.Size(232, 60);
            this.btnQLKho.TabIndex = 1;
            this.btnQLKho.Text = "Quản lý Kho";
            this.btnQLKho.UseVisualStyleBackColor = false;
            this.btnQLKho.Click += new System.EventHandler(this.btnQLKho_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.logocompany);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 796);
            this.panel1.TabIndex = 1;
            // 
            // logocompany
            // 
            this.logocompany.BackColor = System.Drawing.Color.White;
            this.logocompany.Image = global::LKMT.Properties.Resources.logo;
            this.logocompany.Location = new System.Drawing.Point(-13, 0);
            this.logocompany.Margin = new System.Windows.Forms.Padding(4);
            this.logocompany.Name = "logocompany";
            this.logocompany.Size = new System.Drawing.Size(247, 153);
            this.logocompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logocompany.TabIndex = 2;
            this.logocompany.TabStop = false;
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(233, 21);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1292, 775);
            this.panelControl.TabIndex = 9;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 796);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelDropdown.ResumeLayout(false);
            this.PanelDropdown2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logocompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logocompany;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelDropdown;
        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnNhomSP;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnThuongHieu;
        private System.Windows.Forms.Panel PanelDropdown2;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnQLKho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button button2;
    }
}