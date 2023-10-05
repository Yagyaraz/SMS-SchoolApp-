using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SMSApp_School_.Data
{
    public class SMSDbContext:IdentityDbContext
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options) : base(options) { 
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        #region Common
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Batch> Batche { get; set; }
        public DbSet<Grade> Grade { get; set; }
        #endregion
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher {  get; set; }

    }
}
