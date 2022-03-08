using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BDTBaithuchanh345.Models
{
    public partial class BtlDbcontext : DbContext
    {
        public BtlDbcontext(): base("name=BtlDbcontext") { }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}