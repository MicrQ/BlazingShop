﻿namespace BlazingShop.Shared;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; } = "https://via.placeholder.com/300x300";
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public bool IsPublic { get; set; }
    public bool IsDeleted { get; set; }
    public Category category { get; set; }
    public int CategoryId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; }
}
