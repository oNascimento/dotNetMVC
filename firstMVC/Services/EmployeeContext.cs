using firstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace firstMVC.Services
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
                : base (options){}
    }
}