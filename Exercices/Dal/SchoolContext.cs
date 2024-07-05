using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class SchoolContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        public SchoolContext(DbContextOptions options) : base(options)
        {
        }

        public SchoolContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SCHOOL_DATABASE;Trusted_Connection=True");
                    //.UseUpperSnakeCaseNamingConvention();

            }

        }

        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    configurationBuilder.Conventions.Remove();

        //    base.ConfigureConventions(configurationBuilder);
        //}
    }


}
