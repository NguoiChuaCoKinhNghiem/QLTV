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
    public partial class frmPhieuMuonSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        ThanhVien tv;
        Sach s;
        public frmPhieuMuonSach()
        {
            InitializeComponent();
        }
        
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaoPhieuTra_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPhieuMuonSach_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi()
        {
            

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                
                txtTimKiem.Text = li.SubItems[0].Text;
            }
        }
    }
}
