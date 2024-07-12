using BlazingShop.Shared;

namespace BlazingShop.Client;

public interface ICategoryService
{
    List<Category> Categories { get; set; }
    Task LoadCategories();
}
