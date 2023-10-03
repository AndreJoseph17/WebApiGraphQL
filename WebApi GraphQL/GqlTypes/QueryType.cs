using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_GraphQL.Context;
using WebApi_GraphQL.Data.Entities;

namespace WebApi_GraphQL.GqlTypes
{
    public class QueryType
    {
        public async Task<List<Producto>> AllProductsAsync([Service] DbContextClass context)
        {
            return await context.Productos.ToListAsync();
        }

        public async Task<Producto> GetProductAsync([Service] DbContextClass context, int id)
        {
            var productToFind = await context.Productos.FindAsync(id);
            return productToFind;
        }
    }
}
