namespace CakesDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrimerZakaz")]
    public partial class PrimerZakaz
    {
        public int Id { get; set; }

        public int Nomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public virtual Izdelie Izdelie { get; set; }
    }
}
