using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace StocKeeper.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string ContactInfo { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; } // Navigation Property
    }
}