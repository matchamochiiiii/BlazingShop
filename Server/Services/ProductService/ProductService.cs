using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }
        public Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            throw new NotImplementedException();
        }

        public List<Product> Products { get; set; } = new List<Product> {
        new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description= "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Ready Player One",
                    Description= "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernel",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 7.99m,
                    OriginalPrice = 14.99m,
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    Price = 73.99m,
                    OriginalPrice = 400m,
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Description = "Diablo II is an action reol-playing hack-and-slash computer game developed by Blizzard North and published",
                    Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    Price = 8.99m,
                    OriginalPrice = 24.99m,
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    Price = 14.99m,
                    OriginalPrice = 24.99m,
                },
            };
    }
}
