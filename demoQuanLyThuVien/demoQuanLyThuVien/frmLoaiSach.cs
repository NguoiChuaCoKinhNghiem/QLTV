using demoQuanLyThuVien.Model;
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
    public partial class frmLoaiSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                txtTimKiem.Text = li.SubItems[0].Text;
                txtTenLoai.Text = li.SubItems[1].Text;
            }
        }
    }
}
