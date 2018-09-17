using Microsoft.EntityFrameworkCore.Migrations;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners(name, surname, Phone) VALUES ('Radoslaw', 'Wojcik', '123123123')");
            migrationBuilder.Sql("INSERT INTO Owners(name, surname, Phone) VALUES ('Jan', 'Kowalski', '123167677')");
            migrationBuilder.Sql("INSERT INTO Owners(name, surname, Phone) VALUES ('Franek', 'Jaki', '298765434')");

            migrationBuilder.Sql("INSERT INTO Addresses(street, city) VALUES ('Westerplatte', 'Gromnik')");
            migrationBuilder.Sql("INSERT INTO Addresses(street, city) VALUES ('Jana Pawła', 'Tuchów')");
            migrationBuilder.Sql("INSERT INTO Addresses(street, city) VALUES ('Młoda', 'Ciężkowice')");

            migrationBuilder.Sql("INSERT INTO Properties(Type, description, rooms, area, washer, Refrigerator, Iron, addressid, ownerid) VALUES (0, 'Cos tam1', 5, 150, 1, 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Properties(Type, description, rooms, area, washer, Refrigerator, Iron, addressid, ownerid) VALUES (1, 'Cos tam2', 3, 50, 0, 1, 0, 2, 2)");
            migrationBuilder.Sql("INSERT INTO Properties(Type, description, rooms, area, washer, Refrigerator, Iron, addressid, ownerid) VALUES (0, 'Cos tam3', 7, 250, 1, 0, 1, 3, 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from owners");
            migrationBuilder.Sql("Delete from addresses");
            migrationBuilder.Sql("Delete from properties");
        }
    }
}
