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

        // --- HÀM MỚI: Dùng để khóa/mở các nút và ô textbox ---
        private void TrangThai(bool isEditing)
        {
            // Các nút thao tác
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;

            // Nếu trên giao diện có nút Hủy thì bạn bỏ comment dòng dưới nhé:
            // btnHuy.Enabled = isEditing;

            // Các ô nhập liệu
            txtTenLinhKien.Enabled = isEditing;
            txtGia.Enabled = isEditing;
            cboNhomLK.Enabled = isEditing;
            cboLoaiLK.Enabled = isEditing;
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
            // (Giữ nguyên toàn bộ code cũ)
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        string fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        newPath = "..\\..\\image\\" + fileName;
                        lbPath.Text = fileName;
                        pictureLinhKien.Image = new Bitmap(openFileDialog1.FileName);
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
            Int32 selectedRowCount = dgvSanPham.Rows.GetRowCount(DataGridViewElementStates.Selected);
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
            Int32 selectedRowCount = dgvSanPham.Rows.GetRowCount(DataGridViewElementStates.Selected);
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
            if (isThem == true)
            {
                // -- BẮT ĐẦU: Giữ nguyên logic cũ của nút btnThem --
                if (txtMaLinhKien.TextLength > 10)
                {
                    MessageBox.Show("Mã không được vượt quá 10 ký tự!!", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (txtTenLinhKien.TextLength == 0)
                    MessageBox.Show("Tên không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
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
                        TrangThai(false); // Lưu xong thì khóa Form lại
                    }
                    else MessageBox.Show("Thêm linh kiện thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
                // -- KẾT THÚC: Logic cũ của nút btnThem --
            }
            else
            {
                // -- BẮT ĐẦU: Giữ nguyên logic cũ của nút btnSua --
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
                    TrangThai(false); // Lưu xong thì khóa Form lại
                }
                else MessageBox.Show("Cập nhật thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                // -- KẾT THÚC: Logic cũ của nút btnSua --
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai(false); 
            btnLamMoi_Click(sender, e); 
        }
    }
}