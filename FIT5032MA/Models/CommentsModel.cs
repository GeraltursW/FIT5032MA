using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032MA.Models
{
    public partial class CommentsModel : DbContext
    {
        public CommentsModel()
            : base("name=CommentsModel")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
}
