namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            Tickets = new HashSet<Ticket>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(3)]
        public string num_of_row { get; set; }

        public int? num_of_column { get; set; }

        public bool? seat_type { get; set; }

        public int? cinemaroom_id { get; set; }

        public bool? status { get; set; }

        public bool? is_delete { get; set; }

        public virtual Cinemaroom Cinemaroom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
