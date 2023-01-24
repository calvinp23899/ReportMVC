namespace RDLCDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Column")]
    public partial class Column
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Column()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }

        [Required]
        public string ColumnName { get; set; }

        [StringLength(10)]
        public string Color { get; set; }

        public int? SprintId { get; set; }

        public virtual Sprint Sprint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
