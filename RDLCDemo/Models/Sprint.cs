namespace RDLCDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sprint")]
    public partial class Sprint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprint()
        {
            Columns = new HashSet<Column>();
        }

        public int Id { get; set; }

        [Required]
        public string SprintName { get; set; }

        public int? ProjectId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Column> Columns { get; set; }

        public virtual Project Project { get; set; }
    }
}
