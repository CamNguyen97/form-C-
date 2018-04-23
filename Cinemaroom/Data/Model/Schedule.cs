namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Cinemarooms = new HashSet<Cinemaroom>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? show_case { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_time { get; set; }

        public bool? status { get; set; }

        public int? movie_id { get; set; }

        public bool? is_delete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cinemaroom> Cinemarooms { get; set; }

        public virtual Movy Movy { get; set; }
    }
}
