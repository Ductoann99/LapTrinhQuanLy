using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaithuchanh345.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public String TenStudent { get; set; }
        public string StudentID { get; set; }
    }
}