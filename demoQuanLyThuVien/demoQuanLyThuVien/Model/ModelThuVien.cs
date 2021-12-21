namespace demoQuanLyThuVien.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelThuVien : DbContext
    {
        public ModelThuVien()
            : base("name=ModelThuVien")
        {
        }

        public virtual DbSet<DauSach> DauSach { get; set; }
        public virtual DbSet<NgonNgu> NgonNgu { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public virtual DbSet<PhieuMuonSach> PhieuMuonSach { get; set; }
        public virtual DbSet<PhieuTraSach> PhieuTraSach { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<TacGia> TacGia { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.DauSach1)
                .HasForeignKey(e => e.dausach);

            modelBuilder.Entity<NgonNgu>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.NgonNgu1)
                .HasForeignKey(e => e.ngonngu);

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.NhaXuatBan1)
                .HasForeignKey(e => e.nhaxuatban);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.TacGia1)
                .HasForeignKey(e => e.tacgia);

            modelBuilder.Entity<ThanhVien>()
                .HasMany(e => e.PhieuMuonSach)
                .WithOptional(e => e.ThanhVien)
                .HasForeignKey(e => e.mathanhvien);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.Sach)
                .WithOptional(e => e.TheLoai)
                .HasForeignKey(e => e.loaisach);
        }
    }
}
