namespace CakesDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredients()
        {
            Izdelie = new HashSet<Izdelie>();
        }

        [Key]
        [StringLength(50)]
        public string ArticulIZD { get; set; }

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

        [StringLength(50)]
        public string GOST { get; set; }

        [StringLength(50)]
        public string Fasovka { get; set; }

        [StringLength(50)]
        public string Haracteristika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izdelie> Izdelie { get; set; }
    }
}
