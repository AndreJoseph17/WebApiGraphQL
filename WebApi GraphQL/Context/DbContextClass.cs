using Microsoft.EntityFrameworkCore;
using WebApi_GraphQL.Data.Entities;

namespace WebApi_GraphQL.Context
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
