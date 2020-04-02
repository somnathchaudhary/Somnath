using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurProducts.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public string PDesc { get; set; }
        public float PPrice { get; set; }
    }
}
