namespace WinFormsApp.MainScene
{
    partial class fItems
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
            label2 = new Label();
            label1 = new Label();
            txbPrice = new TextBox();
            txbName = new TextBox();
            panel3 = new Panel();
            btnClose = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(695, 102);
            panel1.TabIndex = 3;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(76, 9);
            lbTiepNhanXe.Margin = new Padding(4, 0, 4, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(517, 82);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Thêm phụ tùng";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbPrice);
            panel2.Controls.Add(txbName);
            panel2.Location = new Point(13, 110);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 150);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(63, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Tên phụ tùng";
            // 
            // txbPrice
            // 
            txbPrice.BackColor = SystemColors.Window;
            txbPrice.ForeColor = SystemColors.WindowText;
            txbPrice.Location = new Point(246, 86);
            txbPrice.Margin = new Padding(4);
            txbPrice.Name = "txbPrice";
            txbPrice.PlaceholderText = "0";
            txbPrice.Size = new Size(378, 31);
            txbPrice.TabIndex = 1;
            // 
            // txbName
            // 
            txbName.Location = new Point(246, 32);
            txbName.Margin = new Padding(4);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Nhập tên phụ tùng";
            txbName.Size = new Size(378, 31);
            txbName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnAdd);
            panel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel3.Location = new Point(13, 268);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 105);
            panel3.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = SystemColors.Window;
            btnClose.Location = new Point(389, 26);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(173, 61);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(83, 26);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 61);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // fItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 395);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "fItems";
            Text = "Thêm phụ tùng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Panel panel2;
        private TextBox txbName;
        private Panel panel3;
        private Button btnAdd;
        private TextBox txbPrice;
        private Label label2;
        private Label label1;
        private Button btnClose;
    }
}