using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneWEBAPI.Migrations
{
    public partial class addmoney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userMoney",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userMoney",
                table: "AspNetUsers");
        }
    }
}
