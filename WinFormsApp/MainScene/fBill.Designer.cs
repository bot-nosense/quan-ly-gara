namespace WinFormsApp.MainScene
{
    partial class fBill
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            dgvList = new DataGridView();
            pnStackPanel = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txbPhone = new TextBox();
            txbUserName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnPrintBill = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            pnStackPanel.SuspendLayout();
            panel4.SuspendLayout();
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
            lbTiepNhanXe.Location = new Point(349, 9);
            lbTiepNhanXe.Margin = new Padding(4, 0, 4, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(664, 82);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Hóa đơn thanh toán";
            lbTiepNhanXe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 8;
            label1.Text = "Thông tin nhập hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(867, 116);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 8;
            label2.Text = "Thông tin nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(1004, 557);
            label3.Name = "label3";
            label3.Size = new Size(214, 54);
            label3.TabIndex = 8;
            label3.Text = "Tổng tiền ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(1004, 611);
            label4.Name = "label4";
            label4.Size = new Size(207, 54);
            label4.TabIndex = 8;
            label4.Text = "20000000";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvList);
            panel2.Location = new Point(12, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 735);
            panel2.TabIndex = 9;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(3, 3);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 62;
            dgvList.Size = new Size(824, 727);
            dgvList.TabIndex = 0;
            // 
            // pnStackPanel
            // 
            pnStackPanel.BorderStyle = BorderStyle.FixedSingle;
            pnStackPanel.Controls.Add(textBox3);
            pnStackPanel.Controls.Add(textBox2);
            pnStackPanel.Controls.Add(textBox1);
            pnStackPanel.Controls.Add(label7);
            pnStackPanel.Controls.Add(label6);
            pnStackPanel.Controls.Add(label5);
            pnStackPanel.Location = new Point(867, 144);
            pnStackPanel.Name = "pnStackPanel";
            pnStackPanel.Size = new Size(465, 180);
            pnStackPanel.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 118);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(279, 31);
            textBox3.TabIndex = 1;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 68);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(279, 31);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 20);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(279, 31);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(25, 121);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 71);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 0;
            label6.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 23);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 0;
            label5.Text = "Nhà cung cấp";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(txbPhone);
            panel4.Controls.Add(txbUserName);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(867, 330);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 180);
            panel4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(152, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(152, 118);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(279, 31);
            txbPhone.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(152, 68);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(279, 31);
            txbUserName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(25, 121);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 0;
            label8.Text = "Điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(25, 71);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 0;
            label9.Text = "Người nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(25, 23);
            label10.Name = "label10";
            label10.Size = new Size(105, 25);
            label10.TabIndex = 0;
            label10.Text = "Ngày nhập";
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.ForestGreen;
            btnPrintBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintBill.ForeColor = SystemColors.Window;
            btnPrintBill.Location = new Point(957, 692);
            btnPrintBill.Margin = new Padding(4);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(308, 59);
            btnPrintBill.TabIndex = 11;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.Window;
            btnClose.Location = new Point(957, 779);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(308, 59);
            btnClose.TabIndex = 12;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 891);
            Controls.Add(btnClose);
            Controls.Add(btnPrintBill);
            Controls.Add(panel4);
            Controls.Add(pnStackPanel);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "fBill";
            Text = "Hóa đơn thanh toán";
            Load += fBill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            pnStackPanel.ResumeLayout(false);
            pnStackPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel pnStackPanel;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox txbPhone;
        private TextBox txbUserName;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnPrintBill;
        private Button btnClose;
        private DataGridView dgvList;
        private DateTimePicker dateTimePicker1;
    }
}