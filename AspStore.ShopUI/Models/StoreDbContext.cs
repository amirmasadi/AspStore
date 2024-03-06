using Microsoft.EntityFrameworkCore;

namespace AspStore.ShopUI.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Nothing Phone 2a",
                    Category = "Phone",
                    Description = "Phone (2a) is coming to the US for developers through our new Developer Program.",
                    Price = 17_000_000
                },
                new Product
                {
                    Id = 2,
                    Name = "Google Pixel 8a",
                    Category = "Phone",
                    Description = "The Google Pixel 8a should arrive in May, if we take the 7a's realease as a guideline, and the number of recent leaks makes it plausible.",
                    Price = 20_000_000
                },
                new Product
                {
                    Id = 3,
                    Name = "Iphone SE 4",
                    Category = "Phone",
                    Description = " iPhone SE 4 would include this 5G chip. A report from MacRumors indicated Apple is indeed developing a new iPhone SE that reportedly includes some dramatic upgrades",
                    Price = 20_000_000
                },
                new Product
                {
                    Id = 4,
                    Name = "LG G6",
                    Category = "Phone",
                    Description = "Cutting corners - it's the story of the LG G6's life. And we mean this both literally and figuratively. Literally because its display doesn't have right angles, it's soft arcs instead.",
                    Price = 7_000_000
                },
                new Product
                {
                    Id = 5,
                    Name = "Steam Deck Oled",
                    Category = "PC",
                    Description = "An OLED screen with larger picture, better battery life, faster WiFi—\r\non top of world class ergonomics and an intuitive console-like experience",
                    Price = 40_000_000
                },
                new Product
                {
                    Id = 6,
                    Name = "Lenovo Legion GO",
                    Category = "PC",
                    Description = "Experience handheld gaming perfection with console-level performance and graphics, a super vivid touchscreen display, controls that will keep you at the top of the leaderboards & so much more.\r\n\r\n\r\n",
                    Price = 50_000_000
                },
                new Product
                {
                    Id = 7,
                    Name = "MSI Claw",
                    Category = "PC",
                    Description = "MSI Claw A1M, a groundbreaking handheld gaming device that marks a new era in portable gaming experiences. ",
                    Price = 30_000_000
                },
                new Product
                {
                    Id = 10,
                    Name = "Asus ROG Ally",
                    Category = "PC",
                    Description = "Sink deep into your favorite AAA or indie games and watch the hours melt away with an expansive Full HD 120Hz display and incredibly comfortable ergonomics.",
                    Price = 34_000_000
                },
                new Product
                {
                    Id = 8,
                    Name = "Lenovo Thinkpad L14 Gen1",
                    Category = "Laptop",
                    Description = "    Durable, entry-level 14\" laptop\r\n    Latest processing power\r\n    Professional graphics\r\n    Blazing-fast WiFi\r\n    Time-saving one-touch calling\r\n    All day battery life",
                    Price = 16_000_000
                },
                new Product
                {
                    Id = 9,
                    Name = "MacBook Air M3 2024",
                    Category = "Laptop",
                    Description = "The world’s most popular laptop is better than ever with even more performance, faster Wi-Fi, and support for up to two external displays",
                    Price = 83_000_000
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
