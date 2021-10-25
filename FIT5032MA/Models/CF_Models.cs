using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032MA.Models
{
    public partial class CF_Models : DbContext
    {
        public CF_Models()
            : base("name=CF_Models")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Fund> Funds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Funds)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);
        }

    }
}
