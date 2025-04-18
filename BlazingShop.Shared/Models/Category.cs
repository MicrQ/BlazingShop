﻿namespace BlazingShop.Shared;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public List<Product> Products { get; set; }
}