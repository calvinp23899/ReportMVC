namespace RDLCDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public int NoteId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public virtual Note Note { get; set; }
    }
}
