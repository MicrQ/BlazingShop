using BlazingShop.Shared;

namespace BlazingShop.Client;

public interface IProductServices
{
    List<Product> Products { get; set; }
    void LoadProducts();
}
