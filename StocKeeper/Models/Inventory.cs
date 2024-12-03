using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StocKeeper.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; } // Primary Key

        [Required]
        public int ProductID { get; set; } // Foreign Key

        [ForeignKey("ProductID")]
        public Product Product { get; set; } // Navigation Property

        [Required]
        public int Quantity { get; set; } // Adjustment amount

        [Required]
        [StringLength(50)]
        public string AdjustmentType { get; set; } // Incoming or Outgoing

        public DateTime Date { get; set; } = DateTime.Now; // Adjustment date
    }
}