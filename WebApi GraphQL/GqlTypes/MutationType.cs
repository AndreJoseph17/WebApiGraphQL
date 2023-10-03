using WebApi_GraphQL.Context;
using WebApi_GraphQL.Data.Entities;

namespace WebApi_GraphQL.GqlTypes
{
    public class MutationType
    {
        public async Task<Producto> SaveProductAsync([Service] DbContextClass context,
        Producto newProduct)
        {
            context.Productos.Add(newProduct);
            await context.SaveChangesAsync();
            return newProduct;
        }

        public async Task<Producto> UpdateProductAsync([Service] DbContextClass context, Producto updateProduct)
        {
            context.Productos.Update(updateProduct);
            await context.SaveChangesAsync();
            return updateProduct;
        }

        public async Task<string> DeleteProductAsync([Service] DbContextClass context, int id)
        {
            var productToDelete = await context.Productos.FindAsync(id);
            if (productToDelete == null)
            {
                return "Operación inválido";
            }
            context.Productos.Remove(productToDelete);
            await context.SaveChangesAsync();
            return "Producto Borrado!";
        }
    }
}
