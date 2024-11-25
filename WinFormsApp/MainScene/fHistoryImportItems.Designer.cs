namespace WinFormsApp.MainScene
{
    partial class fHistoryImportItems
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
            textBox2 = new TextBox();
            btnLoad = new Button();
            btnRefresh = new Button();
            btnExport = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            cbSupplier = new ComboBox();
            dpImportDate = new DateTimePicker();
            txbID = new TextBox();
            dgvDatagrid_Import = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatagrid_Import).BeginInit();
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
            panel1.TabIndex = 6;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(402, 9);
            lbTiepNhanXe.Margin = new Padding(4, 0, 4, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(621, 82);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Lịch sử nhập hàng";
            lbTiepNhanXe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(cbSupplier);
            panel2.Controls.Add(dpImportDate);
            panel2.Controls.Add(txbID);
            panel2.Location = new Point(13, 110);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1318, 82);
            panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(463, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Đơn vị cung cấp";
            textBox2.Size = new Size(150, 33);
            textBox2.TabIndex = 11;
            textBox2.Enter += textBox2_Enter;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.RoyalBlue;
            btnLoad.ForeColor = SystemColors.Window;
            btnLoad.Location = new Point(1123, 18);
            btnLoad.Margin = new Padding(4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(133, 41);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Xem";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Black;
            btnRefresh.ForeColor = SystemColors.Window;
            btnRefresh.Location = new Point(841, 18);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 41);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.ForestGreen;
            btnExport.ForeColor = SystemColors.Window;
            btnExport.Location = new Point(982, 18);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(133, 41);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Gray;
            btnSearch.ForeColor = SystemColors.Window;
            btnSearch.Location = new Point(700, 18);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 41);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ngày nhập hàng";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 10;
            textBox1.Enter += textBox1_Enter;
            // 
            // cbSupplier
            // 
            cbSupplier.DisplayMember = "Phụ tùng ô tô Minh Châu";
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Items.AddRange(new object[] { "Phụ tùng ô tô Minh Châu", "Phụ tùng ô tô Cửu Long", "Phụ tùng Trung Quốc" });
            cbSupplier.Location = new Point(463, 23);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(230, 33);
            cbSupplier.TabIndex = 9;
            cbSupplier.SelectionChangeCommitted += cbSupplier_SelectionChangeCommitted;
            cbSupplier.DropDownClosed += cbSupplier_DropDownClosed;
            // 
            // dpImportDate
            // 
            dpImportDate.Format = DateTimePickerFormat.Custom;
            dpImportDate.Location = new Point(260, 25);
            dpImportDate.Name = "dpImportDate";
            dpImportDate.Size = new Size(197, 31);
            dpImportDate.TabIndex = 8;
            dpImportDate.ValueChanged += dtpDatePicker_ValueChanged;
            // 
            // txbID
            // 
            txbID.Location = new Point(56, 25);
            txbID.Margin = new Padding(4);
            txbID.Name = "txbID";
            txbID.PlaceholderText = "Mã đơn nhập";
            txbID.Size = new Size(197, 31);
            txbID.TabIndex = 0;
            // 
            // dgvDatagrid_Import
            // 
            dgvDatagrid_Import.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatagrid_Import.Location = new Point(13, 199);
            dgvDatagrid_Import.Name = "dgvDatagrid_Import";
            dgvDatagrid_Import.RowHeadersWidth = 62;
            dgvDatagrid_Import.Size = new Size(1318, 501);
            dgvDatagrid_Import.TabIndex = 8;
            dgvDatagrid_Import.CellFormatting += dgvDatagrid_Import_CellFormatting;
            // 
            // fHistoryImportItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 712);
            Controls.Add(dgvDatagrid_Import);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fHistoryImportItems";
            Text = "Lịch sử nhập hàng";
            Load += fImportItems_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatagrid_Import).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Panel panel2;
        private TextBox txbID;
        private Button btnSearch;
        private ComboBox cbSupplier;
        private DateTimePicker dpImportDate;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLoad;
        private Button btnRefresh;
        private Button btnExport;
        private DataGridView dgvDatagrid_Import;
    }
}