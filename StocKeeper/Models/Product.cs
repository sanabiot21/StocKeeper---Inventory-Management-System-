using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StocKeeper.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        public int SupplierID { get; set; } // Foreign Key

        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; } // Navigation Property

        public int StockLevel { get; set; } // Current stock
        public decimal Price { get; set; } // Price per unit
    }
}