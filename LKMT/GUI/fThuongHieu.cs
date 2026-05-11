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
    public partial class fThuongHieu : UserControl
    {
        bool isThem = false; // Biến cờ đánh dấu đang Thêm hay Sửa

        public fThuongHieu()
        {
            InitializeComponent();
            ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu);
            dgvThuongHieu.Columns[0].HeaderText = "Mã thương hiệu";
            dgvThuongHieu.Columns[1].HeaderText = "Tên thương hiệu";
            dgvThuongHieu.Columns[2].HeaderText = "ID nhóm";
            dgvThuongHieu.Columns[3].HeaderText = "Ngày tạo";
            dgvThuongHieu.Columns[4].HeaderText = "Ngày cập nhật";
            dgvThuongHieu.Columns[0].Width = 50;
            dgvThuongHieu.Columns[1].Width = 170;
            dgvThuongHieu.Columns[2].Width = 100;
            dgvThuongHieu.Columns[3].Width = 80;
            dgvThuongHieu.Columns[4].Width = 80;
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
            txtTenThuongHieu.Enabled = isEditing;
            cboNhomLK.Enabled = true;

            // Chỉ cho phép nhập/sửa mã khi đang thêm mới
            txtMaTH.Enabled = (isEditing && isThem);
        }

        // --- HÀM MỚI: Bôi xanh dòng vừa thao tác trên DataGridView ---
        private void FocusVaoDongVuaThaoTac(string giaTriCanTim, int cotTimKiem)
        {
            dgvThuongHieu.ClearSelection();
            foreach (DataGridViewRow row in dgvThuongHieu.Rows)
            {
                if (row.Cells[cotTimKiem].Value != null && row.Cells[cotTimKiem].Value.ToString() == giaTriCanTim)
                {
                    row.Selected = true;
                    dgvThuongHieu.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void dgvThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvThuongHieu.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount >= 1)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dgvThuongHieu.Rows[e.RowIndex];
                    txtMaTH.Text = row.Cells[0].Value.ToString();
                    txtTenThuongHieu.Text = row.Cells[2].Value.ToString();
                    NhomSanPhamBUS.Instance.showTenNhomToCBO(row.Cells[2].Value.ToString(), cboNhomLK);
                    txtNgayTao.Text = row.Cells[3].Value.ToString();
                    txtNgayCapNhat.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTH.Text = "";
            txtTenThuongHieu.Text = "";
            txtNgayCapNhat.Text = "";
            txtNgayTao.Text = "";
        }

        // CHỈNH SỬA: Nút Thêm mở khóa form để gõ mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true; // Đánh dấu đang Thêm
            btnLamMoi_Click(sender, e); // Xóa trắng text
            TrangThai(true); // Mở khóa form
        }

        // CHỈNH SỬA: Nút Sửa mở khóa form để chỉnh sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvThuongHieu.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                isThem = false; // Đánh dấu đang Sửa
                TrangThai(true); // Mở khóa form
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thương hiệu muốn cập nhật!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        // CHỈNH SỬA: Gắn thêm hộp thoại hỏi Yes/No trước khi xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvThuongHieu.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thương hiệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (ThuongHieuBUS.Instance.xoaThuongHieu(int.Parse(txtMaTH.Text)))
                    {
                        MessageBox.Show("Xóa thương hiệu thành công!!", "Thông Báo", MessageBoxButtons.OK);
                        ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu, cboNhomLK);
                        btnLamMoi_Click(sender, e);

                        // Xóa xong tự động nhảy con trỏ lên dòng đầu tiên
                        if (dgvThuongHieu.Rows.Count > 0)
                        {
                            dgvThuongHieu.ClearSelection();
                            dgvThuongHieu.CurrentCell = dgvThuongHieu.Rows[0].Cells[0];
                            dgvThuongHieu.Rows[0].Selected = true;
                        }
                    }
                    else MessageBox.Show("Xóa thương hiệu thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thương hiệu muốn xóa!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void cboNhomLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu, cboNhomLK);
        }

        private void fThuongHieu_Load(object sender, EventArgs e)
        {
            ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu, cboNhomLK);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenCanTim = txtTenThuongHieu.Text;
            string maCanTim = txtMaTH.Text;

            if (isThem)
            {
                if (txtTenThuongHieu.TextLength == 0)
                    MessageBox.Show("Tên không được bỏ trống!!", "Thông Báo", MessageBoxButtons.OK);
                else
                {
                    if (ThuongHieuBUS.Instance.themThuongHieu(txtMaTH.Text, txtTenThuongHieu.Text, cboNhomLK))
                    {
                        MessageBox.Show("Thêm thương hiệu thành công!!", "Thông Báo", MessageBoxButtons.OK);
                        ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu, cboNhomLK);
                        btnLamMoi_Click(sender, e);

                        TrangThai(false); // Lưu xong khóa form
                        FocusVaoDongVuaThaoTac(tenCanTim, 1); // Bôi xanh dòng vừa thêm theo Tên (Cột 1)
                    }
                    else MessageBox.Show("Thêm thương hiệu thất bại!!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (ThuongHieuBUS.Instance.suaThuongHieu(int.Parse(txtMaTH.Text), txtTenThuongHieu.Text, cboNhomLK, DateTime.Parse(txtNgayTao.Text)))
                {
                    MessageBox.Show("Cập nhật thương hiệu thành công!!", "Thông Báo", MessageBoxButtons.OK);
                    ThuongHieuBUS.Instance.showListThuongHieu(dgvThuongHieu, cboNhomLK);
                    btnLamMoi_Click(sender, e);

                    TrangThai(false); // Lưu xong khóa form
                    FocusVaoDongVuaThaoTac(maCanTim, 0); // Bôi xanh dòng vừa sửa theo Mã (Cột 0)
                }
                else MessageBox.Show("Cập nhật thương hiệu thất bại!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai(false); // Khóa form
            btnLamMoi_Click(sender, e); // Xóa trắng dữ liệu nhập dở
        }

        private void txtTenThuongHieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}