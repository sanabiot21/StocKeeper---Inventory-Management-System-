using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StocKeeper.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int OrderID { get; set; } // Primary Key

        [Required]
        public int SupplierID { get; set; } // Foreign Key

        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; } // Navigation Property

        public DateTime Date { get; set; } = DateTime.Now; // Order creation date

        [StringLength(50)]
        public string Status { get; set; } // Pending, Fulfilled, etc.

       
    }
}