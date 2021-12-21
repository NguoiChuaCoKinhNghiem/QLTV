using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoQuanLyThuVien
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();

            //txtDate.Text = DateTime.Today.Date.ToShortDateString()+DateTime.Now.ToLongTimeString();
            txtTentt.Text = "Ngô Thùy Thương";
            txtDate.Text = DateTime.Today.Date.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm");

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPhieuMuonSach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
           
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
