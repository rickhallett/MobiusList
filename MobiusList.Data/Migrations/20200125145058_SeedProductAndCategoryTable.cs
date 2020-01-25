using Microsoft.EntityFrameworkCore.Migrations;

namespace MobiusList.Data.Migrations
{
    public partial class SeedProductAndCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category (Name) VALUES ('Technology')");
            migrationBuilder.Sql("INSERT INTO Category (Name) VALUES ('Peripheral')");
            migrationBuilder.Sql("INSERT INTO Category (Name) VALUES ('Book')");
            
            migrationBuilder.Sql(
                "INSERT INTO Product (Name, Description, Price, CategoryId) VALUES ('Macbook Pro', 'Sleek, Powerful, Reasonably Priced', '23999', (SELECT CategoryId FROM Category WHERE Name = 'Technology'))");
            
            migrationBuilder.Sql(
                "INSERT INTO Product (Name, Description, Price, CategoryId) VALUES ('Dell XPS', 'Shame its Windows', '1899', (SELECT CategoryId FROM Category WHERE Name = 'Technology'))");
            
            migrationBuilder.Sql(
                "INSERT INTO Product (Name, Description, Price, CategoryId) VALUES ('Logitech Mouse', 'More features than you will ever use', '89.99', (SELECT CategoryId FROM Category WHERE Name = 'Peripheral'))");
            
            migrationBuilder.Sql(
                "INSERT INTO Product (Name, Description, Price, CategoryId) VALUES ('Azio Retro Keyboard', 'No, this isnt cool', '89.99', (SELECT CategoryId FROM Category WHERE Name = 'Peripheral'))");
            
            migrationBuilder.Sql(
                "INSERT INTO Product (Name, Description, Price, CategoryId) VALUES ('Change Things Until They Work, OReily', 'Real Development', '19.99', (SELECT CategoryId FROM Category WHERE Name = 'Book'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Product");
            
            migrationBuilder.Sql("DELETE FROM Category");
        }
    }
}
