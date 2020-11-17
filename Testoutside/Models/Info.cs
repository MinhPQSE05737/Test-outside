namespace TestOutside.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Info")]
    public partial class Info
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int age { get; set; }
    }
}
