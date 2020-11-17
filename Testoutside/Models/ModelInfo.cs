using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestOutside.Models
{
    public partial class ModelInfo : DbContext
    {
        public ModelInfo()
            : base("name=ModelInfo")
        {
        }

        public virtual DbSet<Info> Infoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
