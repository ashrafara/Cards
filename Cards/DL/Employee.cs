namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Disptaches = new HashSet<Disptach>();
        }

        public int employeeId { get; set; }

        [StringLength(250)]
        public string employeeName { get; set; }

        [StringLength(150)]
        public string employeePosition { get; set; }

        public double? empMobileMonthly { get; set; }

        public double? empFuelMonthly { get; set; }

        public double? empInternetMonthly { get; set; }

        [StringLength(150)]
        public string employeeNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disptach> Disptaches { get; set; }
    }
}
