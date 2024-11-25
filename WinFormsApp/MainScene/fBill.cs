using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.MainScene
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            dgvList.Columns.Add("Column1", "STT");
            dgvList.Columns.Add("Column2", "Vật tư");
            dgvList.Columns.Add("Column3", "Số lượng");
            dgvList.Columns.Add("Column4", "Giá nhập");
            dgvList.Columns.Add("Column5", "Đơn giá");

            dgvList.Rows.Add("1", "Ắc quy Đồng Nai", "1", "200000", "200000");

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.AllowUserToAddRows = false;
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện in hóa đơn
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện đóng
        }
    }
}
