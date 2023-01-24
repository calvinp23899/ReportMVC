namespace RDLCDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Note()
        {
            Comments = new HashSet<Comment>();
            UserVotes = new HashSet<UserVote>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public int ColumnId { get; set; }

        public int UserId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public int? Order { get; set; }

        public virtual Column Column { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserVote> UserVotes { get; set; }
    }
}
