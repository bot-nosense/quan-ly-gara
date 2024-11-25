namespace WinFormsApp.MainScene
{
    partial class fImportItems
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
            panel1 = new Panel();
            lbTiepNhanXe = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            cbSupplies = new ComboBox();
            btnDelete = new Button();
            btnAddGood = new Button();
            txbCost = new TextBox();
            txbPrice = new TextBox();
            label7 = new Label();
            txbAmount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvdatagrid = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnPay = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(lbTiepNhanXe);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 102);
            panel1.TabIndex = 7;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(386, 9);
            lbTiepNhanXe.Margin = new Padding(4, 0, 4, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(697, 82);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Phiếu nhập phụ tùng";
            lbTiepNhanXe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(cbSupplies);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAddGood);
            panel2.Controls.Add(txbCost);
            panel2.Controls.Add(txbPrice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbAmount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(12, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 591);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(4, 492);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(409, 61);
            button1.TabIndex = 15;
            button1.Text = "Xem hóa đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 99);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Chọn phụ tùng";
            textBox1.Size = new Size(150, 33);
            textBox1.TabIndex = 14;
            textBox1.Enter += textBox1_Enter;
            // 
            // cbSupplies
            // 
            cbSupplies.DisplayMember = "Phụ tùng ô tô Minh Châu";
            cbSupplies.FormattingEnabled = true;
            cbSupplies.Items.AddRange(new object[] { "Phụ tùng A", "Phụ tùng B", "Phụ tùng Trung Quốc" });
            cbSupplies.Location = new Point(151, 99);
            cbSupplies.Name = "cbSupplies";
            cbSupplies.Size = new Size(224, 33);
            cbSupplies.TabIndex = 13;
            cbSupplies.SelectedIndexChanged += cbSupplies_SelectedIndexChanged;
            cbSupplies.SelectionChangeCommitted += cbSupplies_SelectionChangeCommitted;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Window;
            btnDelete.Location = new Point(239, 347);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 61);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddGood
            // 
            btnAddGood.BackColor = Color.RoyalBlue;
            btnAddGood.ForeColor = SystemColors.Window;
            btnAddGood.Location = new Point(29, 347);
            btnAddGood.Margin = new Padding(4);
            btnAddGood.Name = "btnAddGood";
            btnAddGood.Size = new Size(146, 61);
            btnAddGood.TabIndex = 12;
            btnAddGood.Text = "Thêm";
            btnAddGood.UseVisualStyleBackColor = false;
            btnAddGood.Click += btnAddGood_Click;
            // 
            // txbCost
            // 
            txbCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCost.Location = new Point(151, 266);
            txbCost.Name = "txbCost";
            txbCost.PlaceholderText = "0";
            txbCost.ReadOnly = true;
            txbCost.Size = new Size(224, 31);
            txbCost.TabIndex = 10;
            // 
            // txbPrice
            // 
            txbPrice.Location = new Point(151, 157);
            txbPrice.Name = "txbPrice";
            txbPrice.PlaceholderText = "0";
            txbPrice.Size = new Size(224, 31);
            txbPrice.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 272);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 9;
            label7.Text = "Tổng";
            label7.Click += label5_Click;
            // 
            // txbAmount
            // 
            txbAmount.Location = new Point(151, 212);
            txbAmount.Name = "txbAmount";
            txbAmount.PlaceholderText = "0";
            txbAmount.Size = new Size(224, 31);
            txbAmount.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 163);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 9;
            label5.Text = "Giá nhập";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 218);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 9;
            label6.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 102);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 9;
            label4.Text = "Tên phụ tùng";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Desktop;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = SystemColors.Window;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(417, 59);
            panel4.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 40);
            label3.TabIndex = 0;
            label3.Text = "Bảng nhập vật tư";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(489, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(697, 82);
            label2.TabIndex = 0;
            label2.Text = "Phiếu nhập phụ tùng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvdatagrid);
            panel3.Location = new Point(437, 109);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(895, 522);
            panel3.TabIndex = 8;
            // 
            // dgvdatagrid
            // 
            dgvdatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatagrid.Location = new Point(3, 3);
            dgvdatagrid.Name = "dgvdatagrid";
            dgvdatagrid.RowHeadersWidth = 62;
            dgvdatagrid.Size = new Size(887, 514);
            dgvdatagrid.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(437, 666);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 638);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 10;
            label1.Text = "Ngày nhập";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.RoyalBlue;
            btnPay.ForeColor = SystemColors.Window;
            btnPay.Location = new Point(815, 638);
            btnPay.Margin = new Padding(4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(213, 61);
            btnPay.TabIndex = 11;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = SystemColors.Window;
            btnClose.Location = new Point(1118, 638);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(213, 61);
            btnClose.TabIndex = 11;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // fImportItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 712);
            Controls.Add(btnClose);
            Controls.Add(btnPay);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fImportItems";
            Text = "Phiếu nhập phụ tủng";
            Load += fImportItems_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdatagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Button btnPay;
        private Button btnClose;
        private TextBox txbPrice;
        private Label label5;
        private Label label4;
        private TextBox txbCost;
        private Label label7;
        private TextBox txbAmount;
        private Label label6;
        private Button btnDelete;
        private Button btnAddGood;
        private ComboBox cbSupplies;
        private TextBox textBox1;
        private DataGridView dgvdatagrid;
        private Button button1;
    }
}