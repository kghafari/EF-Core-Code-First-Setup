using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day28_EFCore_CodeFirst_Solo.Context
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id=1, Name="Accounting", Location="Newark, NJ", Type="Finance", Budget=32000},
                new Department() { Id=2, Name="Marketing", Location="Hell, MI", Type="Advertising", Budget=1.00},
                new Department() { Id=3, Name="Sales", Location="Daytona, FL", Type="Sales", Budget=32000}
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id=1, FirstName="Dade", LastName="Wilson", Email="zeroC00l@hackerman.com", DepartmentId=1},
                new Employee() { Id=2, FirstName="Mathew", LastName="Lillard", Email="cerealKllr@aol.com", DepartmentId=1},
                new Employee() { Id=3, FirstName="Kate", LastName="Libby", Email="CrashOVERRIDE@hackerman.com", DepartmentId=3},
                new Employee() { Id=4, FirstName="Jerry", LastName="Smith", Email="IAmJerrySmith@hotmail.com", DepartmentId=2}
                );
        }
    }
}
