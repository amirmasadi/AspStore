namespace AspStore.ShopUI.Models
{
    public interface IProductRepository
    {
        PageData<Product> GetAll(int pageNumber, int pageSize);
    }
}
