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
    public partial class frmThanhVien : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
       
        public frmThanhVien()
        {
            InitializeComponent();
        }
        
        //public frmThanhVien(ThanhVien thanhvien)
        //{
            
        //    thanhvien = tv;
        //}

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
           
            
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            hienthi();
            
        }
        public void hienthi()
        {
            
            
        }
        

        private void lvThanhVien_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
