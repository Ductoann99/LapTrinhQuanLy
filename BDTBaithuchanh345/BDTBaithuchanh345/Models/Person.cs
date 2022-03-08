﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDTBaithuchanh345.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string TenPerson { get; set; }
        public string PersonID { get; set; }
    }
}