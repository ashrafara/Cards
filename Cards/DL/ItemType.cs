namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemType")]
    public partial class ItemType
    {
        public int itemTypeId { get; set; }

        [StringLength(150)]
        public string itemTypeName { get; set; }
    }
}
