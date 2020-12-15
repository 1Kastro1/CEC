namespace CakesDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ukrashenia")]
    public partial class Ukrashenia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ukrashenia()
        {
            Izdelie = new HashSet<Izdelie>();
        }

        [Key]
        [StringLength(50)]
        public string ArtikulUKR { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string EdIzm { get; set; }

        public int Quantity { get; set; }

        [StringLength(50)]
        public string Postavshik { get; set; }

        public byte[] Image { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(10)]
        public string Ves { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izdelie> Izdelie { get; set; }
    }
}
