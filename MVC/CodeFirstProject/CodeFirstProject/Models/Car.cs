using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstProject.Models
{
    [Table("tblCar")]
    public class Car
    {
        [Key]
        public int carNo { get; set; }
        public string carName { get; set; }
        public string carDescription { get; set; }
        public string carModel { get; set; }
        public decimal carCost { get; set; }
    }
}