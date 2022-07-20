
using HW15.Configurations;
using HW15.DbModels;
using Microsoft.EntityFrameworkCore;

namespace HW15
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.Entity<Client>().HasData(
                new Client() { ClientId = 1, FirstName = "test1", LastName = "test", ProjectId = 1 },
                new Client() { ClientId = 2, FirstName = "test2", LastName = "test", ProjectId = 2 },
                new Client() { ClientId = 3, FirstName = "test3", LastName = "test", ProjectId = 3 },
                new Client() { ClientId = 4, FirstName = "test4", LastName = "test", ProjectId = 4 },
                new Client() { ClientId = 5, FirstName = "test5", LastName = "test", ProjectId = 5 }
                );

            modelBuilder.Entity<Project>().HasData(
                new Project() { ProjectId = 1, Name = "test1", Budget = 100.0M, ClientId = 1 },
                new Project() { ProjectId = 2, Name = "test2", Budget = 100.0M, ClientId = 2 },
                new Project() { ProjectId = 3, Name = "test3", Budget = 100.0M, ClientId = 3 },
                new Project() { ProjectId = 4, Name = "test4", Budget = 100.0M, ClientId = 4 },
                new Project() { ProjectId = 5, Name = "test5", Budget = 100.0M, ClientId = 5 }
            );
        }
    }
}
