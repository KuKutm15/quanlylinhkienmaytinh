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
    public partial class fLoaiSP : UserControl
    {
        bool isThem = false; // Biến cờ đánh dấu đang Thêm hay Sửa

        public fLoaiSP()
        {
            InitializeComponent();
            LoaiSanPhamBUS.Instance.showLoaiSP(dgvLoaiSP);
            dgvLoaiSP.Columns[0].HeaderText = "Mã loại";
            dgvLoaiSP.Columns[1].HeaderText = "Tên loại";
            dgvLoaiSP.Columns[2].HeaderText = "Tên nhóm";
            dgvLoaiSP.Columns[3].HeaderText = "Ngày tạo";
            dgvLoaiSP.Columns[4].HeaderText = "Ngày cập nhật";
            dgvLoaiSP.Columns[0].Width = 50;
            dgvLoaiSP.Columns[1].Width = 170;
            dgvLoaiSP.Columns[2].Width = 100;
            dgvLoaiSP.Columns[3].Width = 80;
            dgvLoaiSP.Columns[4].Width = 80;
            NhomSanPhamBUS.Instance.showListNhomSP(cboNhomLK);

            // Mới mở form lên thì khóa các ô lại, mờ nút Lưu/Hủy
            TrangThai(false);
        }

        // --- HÀM MỚI: Khóa / Mở khóa các nút và ô textbox ---
        private void TrangThai(bool isEditing)
        {
            // Nút chức năng
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            // Ô nhập liệu
            txtTenLoai.Enabled = isEditing;
            cboNhomLK.Enabled = isEditing;

            // Chỉ cho nhập mã khi đang Thêm (tránh sửa nhầm mã cũ gây lỗi)
            txtMaLoai.Enabled = (isEditing && isThem);
        }

        // --- HÀM MỚI: Bôi xanh dòng vừa thao tác trên DataGridView ---
        private void FocusVaoDongVuaThaoTac(string giaTriCanTim, int cotTimKiem)
        {
            dgvLoaiSP.ClearSelection();
            foreach (DataGridViewRow row in dgvLoaiSP.Rows)
            {
                if (row.Cells[cotTimKiem].Value != null && row.Cells[cotTimKiem].Value.ToString() == giaTriCanTim)
                {
                    row.Selected = true;
                    dgvLoaiSP.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvLoaiSP.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount >= 1)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dgvLoaiSP.Rows[e.RowIndex];
                    txtMaLoai.Text = row.Cells[0].Value.ToString();
                    txtTenLoai.Text = row.Cells[1].Value.ToString();
                    NhomSanPhamBUS.Instance.showTenNhomToCBO(row.Cells[2].Value.ToString(), cboNhomLK);
                    txtNgayTao.Text = row.Cells[3].Value.ToString();
                    txtCapNhat.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenLoai.Text = "";
            txtMaLoai.Text = "";
            txtNgayTao.Text = "";
            txtCapNhat.Text = "";
        }

        private void cboNhomLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiSanPhamBUS.Instance.showListLoaiSP(dgvLoaiSP, cboNhomLK);

        }

        private void fLoaiSP_Load(object sender, EventArgs e)
        {
            LoaiSanPhamBUS.Instance.showListLoaiSP(dgvLoaiSP, cboNhomLK);
        }

        // CHỈNH SỬA: Nút Sửa mở form để chỉnh sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvLoaiSP.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                isThem = false; // Đánh dấu là đang sửa
                TrangThai(true); // Mở khóa form
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại linh kiện muốn cập nhật!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        // CHỈNH SỬA: Nút Thêm mở form để gõ mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true; // Đánh dấu là đang Thêm
            btnLamMoi_Click(sender, e); // Xóa trắng text
            TrangThai(true); // Mở khóa form
        }

        // CHỈNH SỬA: Gắn thêm thông báo hỏi Yes/No trước khi Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvLoaiSP.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại linh kiện này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (LoaiSanPhamBUS.Instance.xoaLoaiSP(txtMaLoai.Text))
                    {
                        MessageBox.Show("Xóa loại linh kiện thành công!!", "Thông Báo", MessageBoxButtons.OK);
                        LoaiSanPhamBUS.Instance.showListLoaiSP(dgvLoaiSP, cboNhomLK);
                        btnLamMoi_Click(sender, e);

                        // Xóa xong tự động nhảy con trỏ lên dòng đầu tiên
                        if (dgvLoaiSP.Rows.Count > 0)
                        {
                            dgvLoaiSP.ClearSelection();
                            dgvLoaiSP.CurrentCell = dgvLoaiSP.Rows[0].Cells[0];
                            dgvLoaiSP.Rows[0].Selected = true;
                        }
                    }
                    else MessageBox.Show("Xóa loại linh kiện thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại linh kiện muốn xóa!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void cboNhomLK_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // CHỈNH SỬA: Gom ruột của Thêm và Sửa vào trong này
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenCanTim = txtTenLoai.Text;
            string maCanTim = txtMaLoai.Text;

            if (isThem)
            {
                // ================= CODE THÊM MỚI =================
                if (txtMaLoai.TextLength > 5)
                {
                    MessageBox.Show("Mã không được vượt quá 5 ký tự!!", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (txtTenLoai.TextLength == 0)
                    MessageBox.Show("Tên không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                else
                {
                    if (LoaiSanPhamBUS.Instance.themLoaiSP(cboNhomLK, txtTenLoai.Text))
                    {
                        MessageBox.Show("Thêm loại linh kiện thành công!!", "Thông Báo", MessageBoxButtons.OK);
                        LoaiSanPhamBUS.Instance.showListLoaiSP(dgvLoaiSP, cboNhomLK);
                        btnLamMoi_Click(sender, e);
                        TrangThai(false); // Lưu xong khóa form

                        // Tìm theo Tên (Cột 1)
                        FocusVaoDongVuaThaoTac(tenCanTim, 1);
                    }
                    else MessageBox.Show("Thêm loại linh kiện thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                // ================= CODE CẬP NHẬT (SỬA) =================
                if (LoaiSanPhamBUS.Instance.suaLoaiSP(txtMaLoai.Text, cboNhomLK, txtTenLoai.Text, DateTime.Parse(txtNgayTao.Text)))
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông Báo", MessageBoxButtons.OK);
                    LoaiSanPhamBUS.Instance.showListLoaiSP(dgvLoaiSP, cboNhomLK);
                    btnLamMoi_Click(sender, e);
                    TrangThai(false); // Lưu xong khóa form

                    // Tìm theo Mã (Cột 0)
                    FocusVaoDongVuaThaoTac(maCanTim, 0);
                }
                else MessageBox.Show("Cập nhật thất bại!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai(false); // Khóa các nút và ô textbox lại
            btnLamMoi_Click(sender, e); // Xóa trắng dữ liệu đang gõ dở
        }
    }
}