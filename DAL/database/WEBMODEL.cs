namespace DAL.database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WEBMODEL : DbContext
    {
        public WEBMODEL()
            : base("name=WEBMODEL")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Extend1)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Extend2)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Extend3)
                .IsUnicode(false);
        }
    }
}
