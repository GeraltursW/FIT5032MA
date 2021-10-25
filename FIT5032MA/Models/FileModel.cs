using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032MA.Models
{
    public partial class FileModel : DbContext
    {
        public FileModel()
            : base("name=FileModel")
        {
        }

        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
