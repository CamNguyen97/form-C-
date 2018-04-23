namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movy()
        {
            movies_movitetype = new HashSet<movies_movitetype>();
            Schedules = new HashSet<Schedule>();
            Studios = new HashSet<Studio>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? year_product { get; set; }

        public int? broadcasting_time { get; set; }

        [StringLength(250)]
        public string descreption { get; set; }

        [StringLength(250)]
        public string trailler { get; set; }

        [StringLength(150)]
        public string image { get; set; }

        public bool? status { get; set; }

        public bool? is_delete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movies_movitetype> movies_movitetype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studio> Studios { get; set; }
    }
}
