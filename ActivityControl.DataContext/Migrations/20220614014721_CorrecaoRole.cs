using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityControl.DataContext.Migrations
{
    public partial class CorrecaoRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__User__role_id__6E565CE8",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_role_id",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_role_id",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK__User__role_id__6E565CE8",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
