using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstProject.Models
{
    public class CarContext : DbContext
    {
        public CarContext() : base("name=Motors") { }

        //add the Dbsets of all the corresponding model classes
        public DbSet<Car> Cars { get; set; }
    }
}