

namespace AspStore.ShopUI.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EFProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public PageData<Product> GetAll(int pageNumber, int pageSize)
        {
            var result = new PageData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = storeDbContext.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = storeDbContext.Products.Count();
            return result;
        }
    }
}
