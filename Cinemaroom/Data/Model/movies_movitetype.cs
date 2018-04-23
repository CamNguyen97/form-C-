namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movies_movitetype
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? movie_id { get; set; }

        public int? movietype_id { get; set; }

        public virtual Movy Movy { get; set; }

        public virtual Movietype Movietype { get; set; }
    }
}
