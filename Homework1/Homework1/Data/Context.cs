using Homework1.Models;
using Microsoft.EntityFrameworkCore;
using Homework1.Models;

namespace Homework1.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}
        
        public DbSet<students> students {get; set;}
        public DbSet<students_description> students_description {get; set;}
    }
}