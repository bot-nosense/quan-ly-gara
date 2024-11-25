using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp.MainScene
{
    public partial class fImportItems : Form
    {
        public fImportItems()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSupplies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            cbSupplies.Focus();
        }

        private void fImportItems_Load(object sender, EventArgs e)
        {
            dgvdatagrid.Columns.Add("Column1", "Vật tư");
            dgvdatagrid.Columns.Add("Column2", "Giá nhập");
            dgvdatagrid.Columns.Add("Column3", "Số lượng");
            dgvdatagrid.Columns.Add("Column4", "Đơn giá");

            dgvdatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động chỉnh cột
            dgvdatagrid.AllowUserToAddRows = false; // Ẩn dòng trống ở cuối
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện thêm
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện xóa
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện thanh toán
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện đóng
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // // xử lý sự kiện mở form xem hóa đơn
        }
    }
}
