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
        public string NamHoc { get; set; }
        public float HocKi { get; set; }
        public float DiemA { get; set; }
        public float DiemB { get; set; }
        public float DiemC { get; set; }
        public float DiemTongKet { get; set; }
        public string MaHocPhan { get; set; }
    }
}