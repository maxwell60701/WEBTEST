namespace DAL.database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DAL.database.sqlserver;

    public partial class WEBMODEL : DbContext
    {
        public WEBMODEL(string name)
            : base(name)
        {
        }

        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Extend1)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Extend2)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Extend3)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
