using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace RepterDB.Model
{
    public class JaratContext : DbContext
    {
        public DbSet<Varos> Varosok { get; set; }
        public DbSet<Jarat> Jatatok { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "SZABI";
            builder.InitialCatalog = "JaratAdatok";
            builder.Authentication = SqlAuthenticationMethod.SqlPassword;
            builder.UserID = "sa";
            builder.Password = "P@ssword1234";
            optionsBuilder.UseSqlServer(builder.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Jarat>().HasOne(x => x.KiinduloVaros).WithMany(x => x.JaratokInnen);
            //modelBuilder.Entity<Jarat>().HasOne(x => x.CelVaros).WithMany(x => x.JaratokIde);

            modelBuilder.Entity<Varos>().HasMany(x => x.JaratokInnen).WithOne(x => x.KiinduloVaros);
            //modelBuilder.Entity<Varos>().HasMany(x => x.JaratokIde).WithOne(x => x.CelVaros);            
        }

        public IEnumerable<Jarat> jaratokIde(Varos v)
        {
            return Jatatok.Include(x => x.CelVaros).Where(x => x.CelVaros.ID == v.ID);
        }
    }
}
