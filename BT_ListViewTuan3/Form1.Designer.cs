using System.Windows.Forms;

namespace BT_ListViewTuan3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Duong", "Phong", "0947299915" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Phan Xi", "Bang", "0325722832" }, -1);
            lview = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtPhone = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lview
            // 
            lview.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lview.FullRowSelect = true;
            lview.GridLines = true;
            lview.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            lview.Location = new Point(45, 83);
            lview.Name = "lview";
            lview.Size = new Size(356, 190);
            lview.TabIndex = 0;
            lview.UseCompatibleStateImageBehavior = false;
            lview.View = View.Details;
            lview.SelectedIndexChanged += lview_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "LastName";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FirstName";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 83);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 153);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 223);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(530, 106);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(125, 27);
            txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(530, 176);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(530, 246);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(396, 312);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(530, 312);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(653, 312);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtPhone);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lview);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lview;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHo;
        private TextBox txtTen;
        private TextBox txtPhone;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
