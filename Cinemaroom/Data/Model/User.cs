namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(150)]
        public string password { get; set; }

        [StringLength(250)]
        public string address { get; set; }

        [StringLength(11)]
        public string phone { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        public bool? status { get; set; }

        public int? role { get; set; }

        public bool? is_delete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
