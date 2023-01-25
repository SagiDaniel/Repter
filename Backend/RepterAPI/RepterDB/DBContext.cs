using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RepterAPI.Infrastructure.Model;

namespace RepterAPI.Infrastructure
{
    public class DBContext : DbContext
    {
        public DbSet<Varos> Varosok { get; set; }
        public DbSet<Jarat> Jaratok { get; set; }
        public DbSet<Legitarsasag> Legitarsasag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ez MySQL kiszolgálókhoz van!
            //optionsBuilder.UseMySQL("server=localhost;database=repter;user=root;password=");

            // Ez Microsoft SQL kiszolgálókhoz van!
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
            modelBuilder.Entity<Varos>().HasKey(x => x.Id);
            modelBuilder.Entity<Jarat>().HasKey(x => x.Id);
            modelBuilder.Entity<Legitarsasag>().HasKey(x => x.Id);

            modelBuilder.Entity<Jarat>().HasOne(x => x.KiinduloVaros);
            modelBuilder.Entity<Jarat>().HasOne(x => x.CelVaros);

           
        }
    }
}
