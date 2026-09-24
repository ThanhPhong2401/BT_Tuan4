namespace BT_Guidulieudi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien f2 = new frmNhanVien();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                dgvNhanVien.Rows.Add(f2.MSNV, f2.TenNV, f2.LuongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && !dgvNhanVien.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;

                frmNhanVien f2 = new frmNhanVien();
                f2.MSNV = row.Cells[0].Value?.ToString();
                f2.TenNV = row.Cells[1].Value?.ToString();
                f2.LuongCB = row.Cells[2].Value?.ToString();

                if (f2.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = f2.MSNV;
                    row.Cells[1].Value = f2.TenNV;
                    row.Cells[2].Value = f2.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && !dgvNhanVien.CurrentRow.IsNewRow)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    dgvNhanVien.Rows.Remove(dgvNhanVien.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
