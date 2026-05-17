using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace LKMT.GUI
{
    public partial class fSanPham : UserControl
    {
        string newPath = null;
        string path = null;
        bool isThem = false; // Biến cờ xác định trạng thái Thêm hay Sửa

        public fSanPham()
        {
            InitializeComponent();
            SanPhamBUS.Instance.showSanPham(dgvSanPham);
            dgvSanPham.Columns[0].HeaderText = "Mã linh kiện";
            dgvSanPham.Columns[1].HeaderText = "Tên linh kiện";
            dgvSanPham.Columns[2].HeaderText = "Giá";
            dgvSanPham.Columns[3].HeaderText = "Mã thương hiệu";
            dgvSanPham.Columns[4].HeaderText = "Mã loại";
            dgvSanPham.Columns[5].HeaderText = "Khuyến mãi";
            dgvSanPham.Columns[6].HeaderText = "Bảo hành";
            dgvSanPham.Columns[7].HeaderText = "Hình";
            dgvSanPham.Columns[8].HeaderText = "Ngày tạo";
            dgvSanPham.Columns[9].HeaderText = "Ngày cập nhật";
            dgvSanPham.Columns[10].HeaderText = "Mô tả";

            dgvSanPham.Columns[0].Width = 60;
            dgvSanPham.Columns[1].Width = 170;
            dgvSanPham.Columns[2].Width = 70;
            dgvSanPham.Columns[3].Width = 60;
            dgvSanPham.Columns[4].Width = 60;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.Columns[6].Width = 50;
            dgvSanPham.Columns[7].Width = 80;
            dgvSanPham.Columns[8].Width = 70;
            dgvSanPham.Columns[9].Width = 70;
            dgvSanPham.Columns[9].Width = 150;

            cboLoaiLK.DisplayMember = "tenloai";
            cboThuongHieu.DisplayMember = "tenthuonghieu";

            NhomSanPhamBUS.Instance.showListNhomSP(cboNhomLK);

            // Gọi hàm trạng thái lúc mới mở Form lên (Khóa ô nhập, ẩn nút Lưu)
            TrangThai(false);
        }

        // : Dùng để khóa/mở các nút và ô textbox ---
        private void TrangThai(bool isEditing)
        {
            // Các nút thao tác
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            // Các ô nhập liệu
            txtTenLinhKien.Enabled = isEditing;
            txtGia.Enabled = isEditing;
            cboNhomLK.Enabled = true;
            cboLoaiLK.Enabled = true;
            cboThuongHieu.Enabled = isEditing;
            nmrBaoHanh.Enabled = isEditing;
            nmrKhuyenMai.Enabled = isEditing;
            richMoTa.Enabled = isEditing;
            btnChonHinh.Enabled = isEditing;
            txtMaLinhKien.Enabled = (isEditing && isThem); // Chỉ mở mã khi đang Thêm
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\LENOVO\\Pictures\\Camera Roll\\laptrinhwin";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true; // Bắt buộc phải có để không lỗi đường dẫn hệ thống

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        string fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);

                        // Lấy thư mục bin\Debug đang chạy của App
                        string appPath = Application.StartupPath;
                        string imageFolder = System.IO.Path.Combine(appPath, "image");

                        // Nếu thư mục image chưa có trong bin\Debug thì tự tạo luôn
                        if (!System.IO.Directory.Exists(imageFolder))
                        {
                            System.IO.Directory.CreateDirectory(imageFolder);
                        }

                        // Ghép tên file vào đường dẫn
                        newPath = System.IO.Path.Combine(imageFolder, fileName);
                        lbPath.Text = fileName;

                        // Chống khóa file ảnh (để lúc thêm/sửa/xóa không bị lỗi File in Use)
                        using (var fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            pictureLinhKien.Image = Image.FromStream(fs);
                        }
                        pictureLinhKien.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // (Giữ nguyên toàn bộ code cũ)
            int selectedRowCount = dgvSanPham.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                    txtMaLinhKien.Text = row.Cells[0].Value.ToString();
                    txtTenLinhKien.Text = row.Cells[1].Value.ToString();
                    txtGia.Text = row.Cells[2].Value.ToString();
                    SanPhamBUS.Instance.showFromGridviewToCBO(row.Cells[4].Value.ToString(), int.Parse(row.Cells[3].Value.ToString()), cboNhomLK, cboLoaiLK, cboThuongHieu);
                    nmrKhuyenMai.Value = int.Parse(row.Cells[5].Value.ToString());
                    nmrBaoHanh.Value = int.Parse(row.Cells[6].Value.ToString());
                    SanPhamBUS.Instance.showImageToPictureBox(row.Cells[7].Value.ToString(), pictureLinhKien);
                    lbPath.Text = row.Cells[7].Value.ToString();
                    txtNgayTao.Text = row.Cells[8].Value.ToString();
                    txtCapNhat.Text = row.Cells[9].Value.ToString();
                    richMoTa.Text = row.Cells[10].Value.ToString();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cboNhomLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (Giữ nguyên toàn bộ code cũ)
            cboThuongHieu.Items.Clear();
            cboLoaiLK.Items.Clear();
            cboLoaiLK.Text = null;
            cboThuongHieu.Text = null;

            SanPhamBUS.Instance.showComboboxChanged(dgvSanPham, cboNhomLK, cboLoaiLK, cboThuongHieu);
        }

        // CHỈNH SỬA: Nút thêm bây giờ chỉ làm nhiệm vụ mở khóa Form để người dùng nhập liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true; // Bật cờ đánh dấu đang Thêm
            btnLamMoi_Click(sender, e); // Xóa trắng ô nhập liệu
            TrangThai(true); // Mở khóa cho phép nhập, sáng nút Lưu
        }

        // CHỈNH SỬA: Nút sửa bây giờ chỉ làm nhiệm vụ mở khóa Form để người dùng sửa nội dung
        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvSanPham.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                isThem = false; // Đánh dấu là đang Sửa
                TrangThai(true); // Mở khóa cho phép nhập, sáng nút Lưu
            }
            else
            {
                MessageBox.Show("Vui lòng chọn linh kiện muốn cập nhật!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa linh kiện này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SanPhamBUS.Instance.xoaNhomSP(txtMaLinhKien.Text))
                {
                    MessageBox.Show("Xóa linh kiện thành công!!", "Thông Báo", MessageBoxButtons.OK);
                    SanPhamBUS.Instance.showSanPham(dgvSanPham);
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa linh kiện thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // (Giữ nguyên toàn bộ code cũ)
            txtMaLinhKien.Text = null;
            txtTenLinhKien.Text = null;
            txtGia.Text = null;
            cboLoaiLK.Text = null;
            cboThuongHieu.Text = null;
            nmrBaoHanh.Value = 0;
            nmrKhuyenMai.Value = 0;
            richMoTa.Text = null;
            pictureLinhKien.Image = null;
        }

        // CHỈNH SỬA: Đưa toàn bộ code Thêm/Sửa cũ của bạn vào nút Lưu này! Không sót 1 dòng!
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // [THÊM 1 DÒNG NÀY ĐỂ LƯU TẠM DỮ LIỆU ĐANG GÕ]: Vì lát nữa code của bạn gọi btnLamMoi sẽ xóa trắng các ô nên phải lưu trước.
            string tenHoacMaCanTim = isThem ? txtTenLinhKien.Text : txtMaLinhKien.Text;

            if (isThem == true)
            {
                if (txtTenLinhKien.TextLength == 0) { 
                        MessageBox.Show("Tên không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (txtGia.TextLength == 0)
                    MessageBox.Show("Giá không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                else if (cboLoaiLK.Text.Length == 0)
                    MessageBox.Show("Loại linh kiện không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                else if (cboThuongHieu.Text.Length == 0)
                    MessageBox.Show("Thương hiệu không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                else if (path == null)
                    MessageBox.Show("Chọn hình cho linh kiện!!", "Thông Báo", MessageBoxButtons.OK);
                else
                {
                    if (SanPhamBUS.Instance.themSanPham(txtTenLinhKien.Text, cboLoaiLK, decimal.Parse(txtGia.Text), cboThuongHieu, (int)nmrBaoHanh.Value, (int)nmrKhuyenMai.Value, lbPath.Text, richMoTa.Text))
                    {
                        MessageBox.Show("Thêm linh kiện thành công!!", "Thông Báo", MessageBoxButtons.OK);
                        SanPhamBUS.Instance.showSanPham(dgvSanPham);
                        if (SanPhamBUS.Instance.isExistImage(lbPath.Text) == false)
                        {
                            System.IO.File.Copy(path, newPath, true);
                        }
                        path = null;
                        btnLamMoi_Click(sender, e);

                        TrangThai(false); // Khóa form lại
                        FocusVaoDongVuaThaoTac(tenHoacMaCanTim, 1); // Bôi xanh tìm theo tên (cột 1)
                    }
                    else MessageBox.Show("Thêm linh kiện thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (SanPhamBUS.Instance.suaSanPham(txtMaLinhKien.Text, txtTenLinhKien.Text, cboLoaiLK, decimal.Parse(txtGia.Text), cboThuongHieu, (int)nmrBaoHanh.Value, (int)nmrKhuyenMai.Value, lbPath.Text, richMoTa.Text, DateTime.Parse(txtNgayTao.Text)))
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông Báo", MessageBoxButtons.OK);
                    SanPhamBUS.Instance.showSanPham(dgvSanPham);
                    if (path != null)
                    {
                        if (SanPhamBUS.Instance.isExistImage(lbPath.Text) == false)
                        {
                            System.IO.File.Copy(path, newPath, true);
                        }
                    }
                    btnLamMoi_Click(sender, e);

                    TrangThai(false); // Khóa form lại
                    FocusVaoDongVuaThaoTac(tenHoacMaCanTim, 0); // Bôi xanh tìm theo mã (cột 0)
                }
                else MessageBox.Show("Cập nhật thất bại!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void FocusVaoDongVuaThaoTac(string giaTriCanTim, int cotTimKiem)
        {
            dgvSanPham.ClearSelection();
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[cotTimKiem].Value != null && row.Cells[cotTimKiem].Value.ToString() == giaTriCanTim)
                {
                    row.Selected = true;
                    dgvSanPham.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai(false); 
            btnLamMoi_Click(sender, e); 
        }
    }
}