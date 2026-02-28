using practiceEFDapper.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using practiceEFDapper.Entities;


namespace practiceEFDapper
{
    class AppDbContext : DbContext
    {
        private readonly string _connectionString = @"Data Source=NIGHTFURY\LEVMSSQLSERVER;Initial Catalog=AcademyDB;Integrated Security=True; TrustServerCertificate=True";
        public DbSet<Student> Students { get; set; }

        public AppDbContext()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();
            _connectionString = config.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
