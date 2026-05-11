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
    public partial class fThanhToan : UserControl
    {
        // Biến cờ để biết đang ở trạng thái Thêm hay Sửa
        bool isThem = false;

        public fThanhToan()
        {
            InitializeComponent();
            LoadData();
            TrangThai(false); // Mặc định khóa các ô nhập liệu
        }

        private void LoadData()
        {
            ThanhToanBUS.Instance.showThanhToan(dgvPhuongThuc);
            dgvPhuongThuc.Columns[0].HeaderText = "Mã phương thức";
            dgvPhuongThuc.Columns[1].HeaderText = "Tên phương thức";
            dgvPhuongThuc.Columns[0].Width = 60;
            dgvPhuongThuc.Columns[1].Width = 175;
        }

        // --- HÀM ĐIỀU KHIỂN TRẠNG THÁI ---
        private void TrangThai(bool isEditing)
        {
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;

            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            txtName.Enabled = isEditing;
            // txtID thường là khóa chính tự tăng nên không cho nhập
            txtID.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isThem = true;
            btnLamMoi_Click(sender, e);
            TrangThai(true); // Mở khóa cho nhập tên mới
            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                isThem = false;
                TrangThai(true); // Mở khóa cho sửa tên
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức muốn cập nhật!!", "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa phương thức này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (ThanhToanBUS.Instance.xoaThanhToan(int.Parse(txtID.Text)))
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông Báo");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                    else MessageBox.Show("Xóa thất bại!!", "Thông Báo");
                }
            }
            else MessageBox.Show("Vui lòng chọn phương thức muốn xóa!!", "Thông Báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên phương thức không được bỏ trống!!", "Thông Báo");
                txtName.Focus();
                return;
            }

            if (isThem)
            {
                // LOGIC THÊM
                if (ThanhToanBUS.Instance.themThanhToan(txtName.Text))
                {
                    MessageBox.Show("Thêm thành công!!", "Thông Báo");
                    LoadData();
                    TrangThai(false); // Xong việc thì khóa lại
                }
                else MessageBox.Show("Thêm thất bại!!", "Thông Báo");
            }
            else
            {
                // LOGIC SỬA
                if (ThanhToanBUS.Instance.suaThanhToan(int.Parse(txtID.Text), txtName.Text))
                {
                    MessageBox.Show("Cập nhật thành công!!", "Thông Báo");
                    LoadData();
                    TrangThai(false);
                }
                else MessageBox.Show("Cập nhật thất bại!!", "Thông Báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai(false); // Khóa lại, không lưu gì cả
            // Load lại dữ liệu cũ từ Grid lên TextBox để tránh hiển thị sai
            dgvPhuongThuc_CellClick(null, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
        }

        private void dgvPhuongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhuongThuc.CurrentRow != null)
            {
                txtID.Text = dgvPhuongThuc.CurrentRow.Cells[0].Value?.ToString();
                txtName.Text = dgvPhuongThuc.CurrentRow.Cells[1].Value?.ToString();
            }
        }
    }
}