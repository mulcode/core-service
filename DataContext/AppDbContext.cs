using CoreService.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreService.DataContext
{
    public class AppDbContext : DbContext
    {

        public DbSet<Group> Groups { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<JobRoles> JobRoles { get; set; }
        public DbSet<Devision> Devisions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<CostToCom> CostToComs { get; set; }
        public DbSet<ArithmaticOperations> ArithmaticOperations { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseNpgsql("Server=localhost;Port=5432; Database=core_service; Username=postgres;Password=root");
    }
}