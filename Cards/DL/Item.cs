namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Disptaches = new HashSet<Disptach>();
            ReceiveOrders = new HashSet<ReceiveOrder>();
        }

        public int itemId { get; set; }

        [StringLength(250)]
        public string itemName { get; set; }

        [StringLength(150)]
        public string itemNotes { get; set; }

        public int? supplierId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disptach> Disptaches { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiveOrder> ReceiveOrders { get; set; }
    }
}
