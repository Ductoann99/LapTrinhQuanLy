using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BDTBaitaplon345.Models
{
    public partial class BtlDbcontext : DbContext
    {
        public BtlDbcontext (): base("name = BtlDbcontext") { }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
    }
}