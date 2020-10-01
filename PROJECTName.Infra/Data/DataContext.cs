using Microsoft.EntityFrameworkCore;
using PROJECTName.Domain.Entities;

namespace PROJECTName.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Example> Examples { get; set; }
    }
}
