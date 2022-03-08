using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaithuchanh345.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public string NameEmployee { get; set; }
        public string Employees { get; set; }
    }
}