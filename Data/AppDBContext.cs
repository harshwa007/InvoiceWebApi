using InvoiceWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
