namespace DAL.database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DAL.database.sqlserver;

    public partial class sqlWEBMODEL : WEBMODEL
    {
        public sqlWEBMODEL()
            : base("name=sqlWEBMODEL")
        {
        }

        public override DbSet<users> users { get; set; }

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
        }
    }
}