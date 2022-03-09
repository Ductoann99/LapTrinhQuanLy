using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaitaplon345.Models
{
    [Table("Diems")]
    public class Diem
    {
        [Key]
        public string ID { get; set; }
        public string MaSinhVien { get; set; }
        public string HocKi { get; set; }
        public string DiemA { get; set; }
        public string DiemB { get; set; }
        public string DiemC { get; set; }
        public string DiemTongKet { get; set; }
        public string MaHocPhan { get; set; }
    }
}