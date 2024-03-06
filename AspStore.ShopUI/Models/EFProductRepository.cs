
namespace AspStore.ShopUI.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EFProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public List<Product> GetAll()
        {
            return storeDbContext.Products.ToList();
        }
    }
}
