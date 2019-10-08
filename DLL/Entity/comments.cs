namespace DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comments
    {
        public int id { get; set; }

        [StringLength(200)]
        public string message { get; set; }

        public int bookID { get; set; }

        public int UserID { get; set; }

        public virtual Books Books { get; set; }

        public virtual Users Users { get; set; }
    }
}
