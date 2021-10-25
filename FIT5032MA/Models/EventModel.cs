using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032MA.Models
{
    public partial class EventModel : DbContext
    {
        public EventModel()
            : base("name=EventModel1")
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Event>()
                .Property(e => e.ThemeColor)
                .IsFixedLength();
        }
    }
}
