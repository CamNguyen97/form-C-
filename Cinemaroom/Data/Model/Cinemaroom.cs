namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cinemaroom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinemaroom()
        {
            Seats = new HashSet<Seat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(150)]
        public string name { get; set; }

        [StringLength(50)]
        public string descreption { get; set; }

        public bool? status { get; set; }

        public int? schedule_id { get; set; }

        public bool? is_delete { get; set; }

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
