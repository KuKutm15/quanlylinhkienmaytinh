namespace LKMT.GUI
{
    partial class fThuongHieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.ddd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
            this.txtMaTH = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.cboNhomLK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuongHieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin thương hiệu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(353, 523);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(167, 277);
            this.txtNgayCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.ReadOnly = true;
            this.txtNgayCapNhat.Size = new System.Drawing.Size(229, 22);
            this.txtNgayCapNhat.TabIndex = 26;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(15, 282);
            this.aaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(117, 16);
            this.aaa.TabIndex = 25;
            this.aaa.Text = "Cập nhật gần nhất:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(167, 215);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(229, 22);
            this.txtNgayTao.TabIndex = 24;
            // 
            // ddd
            // 
            this.ddd.AutoSize = true;
            this.ddd.Location = new System.Drawing.Point(68, 219);
            this.ddd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(65, 16);
            this.ddd.TabIndex = 23;
            this.ddd.Text = "Ngày tạo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Location = new System.Drawing.Point(115, 575);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(358, 115);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(177, 67);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 27);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(81, 67);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 27);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(239, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(123, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenThuongHieu
            // 
            this.txtTenThuongHieu.Location = new System.Drawing.Point(167, 154);
            this.txtTenThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenThuongHieu.Name = "txtTenThuongHieu";
            this.txtTenThuongHieu.Size = new System.Drawing.Size(229, 22);
            this.txtTenThuongHieu.TabIndex = 20;
            this.txtTenThuongHieu.TextChanged += new System.EventHandler(this.txtTenThuongHieu_TextChanged);
            // 
            // txtMaTH
            // 
            this.txtMaTH.Location = new System.Drawing.Point(167, 92);
            this.txtMaTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTH.Name = "txtMaTH";
            this.txtMaTH.ReadOnly = true;
            this.txtMaTH.Size = new System.Drawing.Size(96, 22);
            this.txtMaTH.TabIndex = 19;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(32, 158);
            this.b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(105, 16);
            this.b.TabIndex = 18;
            this.b.Text = "Tên thương hiệu:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(37, 97);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 16);
            this.a.TabIndex = 17;
            this.a.Text = "Mã thương hiệu:";
            // 
            // cboNhomLK
            // 
            this.cboNhomLK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomLK.FormattingEnabled = true;
            this.cboNhomLK.Location = new System.Drawing.Point(167, 39);
            this.cboNhomLK.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhomLK.Name = "cboNhomLK";
            this.cboNhomLK.Size = new System.Drawing.Size(229, 24);
            this.cboNhomLK.TabIndex = 35;
            this.cboNhomLK.SelectedIndexChanged += new System.EventHandler(this.cboNhomLK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nhóm linh kiện:";
            // 
            // dgvThuongHieu
            // 
            this.dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongHieu.Location = new System.Drawing.Point(15, 23);
            this.dgvThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuongHieu.Name = "dgvThuongHieu";
            this.dgvThuongHieu.RowHeadersWidth = 51;
            this.dgvThuongHieu.Size = new System.Drawing.Size(697, 484);
            this.dgvThuongHieu.TabIndex = 36;
            this.dgvThuongHieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuongHieu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThuongHieu);
            this.groupBox2.Location = new System.Drawing.Point(528, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(728, 522);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thương hiệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.a);
            this.groupBox3.Controls.Add(this.cboNhomLK);
            this.groupBox3.Controls.Add(this.b);
            this.groupBox3.Controls.Add(this.txtMaTH);
            this.groupBox3.Controls.Add(this.txtTenThuongHieu);
            this.groupBox3.Controls.Add(this.txtNgayCapNhat);
            this.groupBox3.Controls.Add(this.ddd);
            this.groupBox3.Controls.Add(this.aaa);
            this.groupBox3.Controls.Add(this.txtNgayTao);
            this.groupBox3.Location = new System.Drawing.Point(49, 183);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(439, 318);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thương hiệu";
            // 
            // fThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThuongHieu";
            this.Size = new System.Drawing.Size(1292, 782);
            this.Load += new System.EventHandler(this.fThuongHieu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Label ddd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenThuongHieu;
        private System.Windows.Forms.TextBox txtMaTH;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.ComboBox cboNhomLK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}
