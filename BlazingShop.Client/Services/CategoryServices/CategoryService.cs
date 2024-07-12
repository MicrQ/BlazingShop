using System.Net.Http.Json;
using BlazingShop.Shared;

namespace BlazingShop.Client;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _http;
    public List<Category> Categories { get; set; } = new List<Category>();

    public CategoryService(HttpClient http)
    {
        _http = http;
    }

    public async Task LoadCategories()
    {
        Categories = await _http.GetFromJsonAsync<List<Category>>("http://localhost:5161/api/Category");
    }
}
