using technicalAssesment.Models.Domain;
using Microsoft.EntityFrameworkCore;
using technicalAssesment.Models;

namespace technicalAssesment.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Customer> CustomerData { get; set; }
    }
}
