using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaitaplon345.Models
{
    [Table("GiaoViens")]
    public class GiaoVien
    {
        [Key]
        public string MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public string PhongBan { get; set; }
        public string HocPhanPhuTrach { get; set; }
    }
}