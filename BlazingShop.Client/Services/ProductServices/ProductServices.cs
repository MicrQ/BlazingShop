using BlazingShop.Shared;

namespace BlazingShop.Client;

public class ProductServices : IProductServices
{
    public List<Product> Products { get; set ; } = new List<Product>();

    public void LoadProducts()
    {
        Products = new List<Product>() {
            new Product {
            Id = 1,
            CategoryId = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "A comedy science fiction series created by Douglas Adams",
            Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m,
            OriginalPrice = 19.99m,
            },
            new Product {
                Id = 2,
                CategoryId = 1,
                Title = "Half-Life 2",
                Description = "Half life 2 added in 2004 first person shooter game developed by Valve Corporation",
                Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price = 7.99m,
                OriginalPrice = 12.99m,
            },
            new Product {
                Id = 3,
                CategoryId = 1,
                Title = "Ninteen Eighty-Four",
                Description = "Ninetee Eighty-Four is a dystopian social science fiction novel by English novelist George Orwell",
                Image = "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg",
                Price = 18.99m,
                OriginalPrice = 16.99m,
            },
            new Product {
                Id = 4,
                CategoryId = 2,
                Title = "Pentax Spotmatic",
                Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                Price = 168.99m,
                OriginalPrice = 216.99m,
            },
            new Product {
                Id = 5,
                CategoryId = 2,
                Title = "XBOX",
                Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                Image = "https://upload.wikimedia.org/commons/4/43/Xbox-console.jpg",
                Price = 78.99m,
                OriginalPrice = 160.99m,
            },
            new Product {
                Id = 6,
                CategoryId = 2,
                Title = "Super Nintendo",
                Description = "The Super Nintendo Entertainment System is a home video game console developed by Nintendo. It was released in 1990 in Japan and South Korea, 1991 in North America, 1992 in Europe and Australasia, and 1993 in South America.",
                Image = "https://upload.wikimedia.org/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                Price = 178.99m,
                OriginalPrice = 260.99m,
            }
        };
    }
}
