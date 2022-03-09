using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaitaplon345.Models
{
    [Table("Lops")]
    public class Lop
    {
        [Key]
        public string TenLop { get; set; }
        public string MaLop { get; set; }
        public string MaKhoa { get; set; }
    }
}