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
    public partial class frmPhieuTraSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmPhieuTraSach()
        {
            InitializeComponent();
        }

        private void frmPhieuTraSach_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitao();
        }
        public void hienthi()
        {
            
        }
        public void khoitao()
        {
            cboTT.Items.Clear();
            cboTT.Items.Add("Trả đúng hạn!!!!!!");
            cboTT.Items.Add("Trả trễ hạn!!!!!!!!!!!!");
            cboTT.SelectedIndex = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
        public frmPhieuTraSach(PhieuMuonSach pm)
        {
            InitializeComponent();
            khoitao();
            txtMaPhieuMuon.Text = pm.maphieumuon;
            
        }
    }
}
