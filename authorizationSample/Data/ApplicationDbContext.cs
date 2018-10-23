using System;
using System.Collections.Generic;
using System.Text;
using authorizationSample.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace authorizationSample.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
