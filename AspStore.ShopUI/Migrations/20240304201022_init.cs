using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspStore.ShopUI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Phone", "Phone (2a) is coming to the US for developers through our new Developer Program.", "Nothing Phone 2a", 17000000 },
                    { 2, "Phone", "The Google Pixel 8a should arrive in May, if we take the 7a's realease as a guideline, and the number of recent leaks makes it plausible.", "Google Pixel 8a", 20000000 },
                    { 3, "Phone", " iPhone SE 4 would include this 5G chip. A report from MacRumors indicated Apple is indeed developing a new iPhone SE that reportedly includes some dramatic upgrades", "Iphone SE 4", 20000000 },
                    { 4, "Phone", "Cutting corners - it's the story of the LG G6's life. And we mean this both literally and figuratively. Literally because its display doesn't have right angles, it's soft arcs instead.", "LG G6", 7000000 },
                    { 5, "PC", "An OLED screen with larger picture, better battery life, faster WiFi—\r\non top of world class ergonomics and an intuitive console-like experience", "Steam Deck Oled", 40000000 },
                    { 6, "PC", "Experience handheld gaming perfection with console-level performance and graphics, a super vivid touchscreen display, controls that will keep you at the top of the leaderboards & so much more.\r\n\r\n\r\n", "Lenovo Legion GO", 50000000 },
                    { 7, "PC", "MSI Claw A1M, a groundbreaking handheld gaming device that marks a new era in portable gaming experiences. ", "MSI Claw", 30000000 },
                    { 8, "Laptop", "    Durable, entry-level 14\" laptop\r\n    Latest processing power\r\n    Professional graphics\r\n    Blazing-fast WiFi\r\n    Time-saving one-touch calling\r\n    All day battery life", "Lenovo Thinkpad L14 Gen1", 16000000 },
                    { 9, "Laptop", "The world’s most popular laptop is better than ever with even more performance, faster Wi-Fi, and support for up to two external displays", "MacBook Air M3 2024", 83000000 },
                    { 10, "PC", "Sink deep into your favorite AAA or indie games and watch the hours melt away with an expansive Full HD 120Hz display and incredibly comfortable ergonomics.", "Asus ROG Ally", 34000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
