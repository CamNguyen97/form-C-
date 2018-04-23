namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Studio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public bool? status { get; set; }

        public bool? is_delete { get; set; }

        public int? movie_id { get; set; }

        public virtual Movy Movy { get; set; }
    }
}
