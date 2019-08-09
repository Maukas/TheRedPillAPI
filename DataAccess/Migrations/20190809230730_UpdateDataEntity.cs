using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateDataEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecordName",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecordNumber",
                table: "Datas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordName",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "RecordNumber",
                table: "Datas");
        }
    }
}
