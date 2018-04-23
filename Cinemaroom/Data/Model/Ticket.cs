namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? seat_id { get; set; }

        public double? pay_ticket { get; set; }

        public bool? status { get; set; }

        public bool? is_delete { get; set; }

        public int? user_id { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual User User { get; set; }
    }
}
