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
    public partial class fHistoryImportItems : Form
    {
        public fHistoryImportItems()
        {
            InitializeComponent();
        }

        private void dtpDatePicker_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            dpImportDate.Focus();
        }

        private void fImportItems_Load(object sender, EventArgs e)
        {
            dgvDatagrid_Import.Columns.Add("Column1", "ID");
            dgvDatagrid_Import.Columns.Add("Column2", "Ngày nhập hàng");
            dgvDatagrid_Import.Columns.Add("Column3", "Tổng tiền thanh toán");
            dgvDatagrid_Import.Columns.Add("Column4", "Đơn vị cung cấp");

            dgvDatagrid_Import.Rows.Add("1", "06/25/2021", "2000000", "MAST");
            dgvDatagrid_Import.Rows.Add("2", "07/06/2021", "0", "Phụ tùng ô tô Minh Chi");

            dgvDatagrid_Import.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động chỉnh cột
            dgvDatagrid_Import.AllowUserToAddRows = false; // Ẩn dòng trống ở cuối

            dgvDatagrid_Import.CellFormatting += dgvDatagrid_Import_CellFormatting;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            cbSupplier.Focus();
        }

        private void cbSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void cbSupplier_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void dgvDatagrid_Import_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện tìm kiếm
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện làm mới
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện xuất file excel
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện xem thông tin
        }
    }
}
