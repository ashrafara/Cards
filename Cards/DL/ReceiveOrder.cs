namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveOrder")]
    public partial class ReceiveOrder
    {
        [Key]
        public int receiveId { get; set; }

        [StringLength(100)]
        public string orderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? receiveDate { get; set; }

        [StringLength(150)]
        public string receiveNotes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? orderDate { get; set; }

        public double? receiveQuantity { get; set; }

        public double? receiveTotalPrice { get; set; }

        public double? receiveCommercialPrice { get; set; }

        public double? itemtype1 { get; set; }

        public double? itemQuantity1 { get; set; }

        public double? itemtype2 { get; set; }

        public double? itemQuantity2 { get; set; }

        public int itemId { get; set; }

        public int supplierId { get; set; }

        public virtual Item Item { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
