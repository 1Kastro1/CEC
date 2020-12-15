namespace CakesDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Izdelie")]
    public partial class Izdelie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izdelie()
        {
            PrimerZakaz = new HashSet<PrimerZakaz>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomer { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Izdelie")]
        [Required]
        [StringLength(50)]
        public string Izdelie1 { get; set; }

        [Required]
        [StringLength(50)]
        public string ZakazLogin { get; set; }

        [StringLength(50)]
        public string MenegerLogin { get; set; }

        public decimal? Cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlanEndDate { get; set; }

        [StringLength(50)]
        public string ArtikulUKR { get; set; }

        [StringLength(50)]
        public string ArticulIZD { get; set; }

        public virtual Ingredients Ingredients { get; set; }

        public virtual Ukrashenia Ukrashenia { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimerZakaz> PrimerZakaz { get; set; }
    }
}
