namespace WinFormsApp
{
    partial class fItemInsertionReport
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
            panel3 = new Panel();
            btnClose = new Button();
            btnConfirm = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            cbSupplier = new ComboBox();
            dtpDatePicker = new DateTimePicker();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(838, 102);
            panel1.TabIndex = 6;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(76, 9);
            lbTiepNhanXe.Margin = new Padding(4, 0, 4, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(697, 82);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Phiếu nhập phụ tùng";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnConfirm);
            panel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel3.Location = new Point(13, 350);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(812, 105);
            panel3.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = SystemColors.Window;
            btnClose.Location = new Point(498, 26);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(173, 61);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.RoyalBlue;
            btnConfirm.ForeColor = SystemColors.Window;
            btnConfirm.Location = new Point(125, 26);
            btnConfirm.Margin = new Padding(4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(173, 61);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbSupplier);
            panel2.Controls.Add(dtpDatePicker);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 110);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 232);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._65476_200;
            button2.Location = new Point(145, 67);
            button2.Name = "button2";
            button2.Size = new Size(41, 34);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.date_time_icon2;
            button1.Location = new Point(146, 153);
            button1.Name = "button1";
            button1.Size = new Size(40, 34);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // cbSupplier
            // 
            cbSupplier.DisplayMember = "Phụ tùng ô tô Minh Châu";
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Items.AddRange(new object[] { "Phụ tùng ô tô Minh Châu", "Phụ tùng ô tô Cửu Long", "Phụ tùng Trung Quốc" });
            cbSupplier.Location = new Point(192, 155);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(457, 33);
            cbSupplier.TabIndex = 4;
            // 
            // dtpDatePicker
            // 
            dtpDatePicker.Format = DateTimePickerFormat.Custom;
            dtpDatePicker.Location = new Point(192, 70);
            dtpDatePicker.Name = "dtpDatePicker";
            dtpDatePicker.Size = new Size(457, 31);
            dtpDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(192, 42);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 2;
            label2.Text = "Ngày nhập hàng";
            // 
            // fItemInsertionReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 477);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "fItemInsertionReport";
            Text = "Phiếu nhập phụ tùng";
            Load += fItemInsertionReport_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Panel panel3;
        private Button btnClose;
        private Button btnConfirm;
        private Panel panel2;
        private Label label2;
        private ComboBox cbSupplier;
        private DateTimePicker dtpDatePicker;
        private Button button1;
        private Button button2;
    }
}