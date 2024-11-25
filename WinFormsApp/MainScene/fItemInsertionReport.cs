using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class fItemInsertionReport : Form
    {
        public fItemInsertionReport()
        {
            InitializeComponent();
        }

        private void fItemInsertionReport_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện xác nhận
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện đóng form
        }
    }
}
