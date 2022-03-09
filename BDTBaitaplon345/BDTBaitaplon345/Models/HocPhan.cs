using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaitaplon345.Models
{
    [Table("Hocphans")]
    public class HocPhan
    {
        [Key]
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
        public string SoTinChi { get; set; }
    }
}