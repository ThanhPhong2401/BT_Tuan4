namespace BT_ListViewTuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lview.View = View.Details;
            lview.FullRowSelect = true; // Chọn cả dòng
            lview.GridLines = true;     // Hiện đường lưới

            // Gán sự kiện click dòng trên ListView
            lview.SelectedIndexChanged += lview_SelectedIndexChanged;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtHo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui long nhap đay đu thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo item mới (Cột đầu tiên là Last Name)
            ListViewItem item = new ListViewItem(txtHo.Text);

            // Thêm các sub-item (First Name và Phone)
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(txtPhone.Text);

            // Thêm item vào ListView
            lview.Items.Add(item);

            // Xóa dữ liệu các TextBox sau khi thêm xong
            ClearInputs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lview.SelectedItems.Count > 0)
            {
                ListViewItem item = lview.SelectedItems[0];

                item.Text = txtHo.Text;            // Cập nhật LastName (Cột 0)
                item.SubItems[1].Text = txtTen.Text; // Cập nhật FirstName (Cột 1)
                item.SubItems[2].Text = txtPhone.Text; // Cập nhật Phone (Cột 2)

                MessageBox.Show("Cap nhat thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Chọn dong can sua trong danh sach!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lview.SelectedItems.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Xoa dong da chon?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lview.Items.Remove(lview.SelectedItems[0]);
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Chon dong can xoa trong danh sach!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lview.SelectedItems.Count > 0)
            {
                ListViewItem item = lview.SelectedItems[0];
                txtHo.Text = item.Text;
                txtTen.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }
        private void ClearInputs()
        {
            txtHo.Clear();
            txtTen.Clear();
            txtPhone.Clear();
            txtHo.Focus();
        }
    }
}