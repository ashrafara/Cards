namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Disptach")]
    public partial class Disptach
    {
        public int disptachId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? disptachDate { get; set; }

        public int? disptachTotal { get; set; }

        [StringLength(150)]
        public string disptachNotes { get; set; }

        public int employeeId { get; set; }

        public int itemId { get; set; }

        public int? type1 { get; set; }

        public int? quantity1 { get; set; }

        public int? type2 { get; set; }

        public int? quantity2 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Item Item { get; set; }

        [StringLength(50)]
        public string dispmonth { get; set; }

        [StringLength(50)]
        public string dispyear { get; set; }
    }
}
