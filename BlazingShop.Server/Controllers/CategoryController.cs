﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using BlazingShop.Shared;

namespace BlazingShop.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetCategories() {
        return Ok(new List<Category> {
            new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
            new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
            new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" },
        });
    }
}
