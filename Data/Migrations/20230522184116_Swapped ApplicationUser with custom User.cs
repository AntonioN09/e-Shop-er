using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SwappedApplicationUserwithcustomUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acquisitions_AspNetUsers_UserId",
                table: "Acquisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Histories_UserId",
                table: "Histories");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Notifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Histories",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Carts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId1",
                table: "AspNetUserRoles",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId2",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Acquisitions",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Acquisitions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ApplicationUserId",
                table: "Notifications",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserId",
                table: "Histories",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HistoryId",
                table: "AspNetUsers",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId2",
                table: "AspNetUserRoles",
                column: "UserId2");

            migrationBuilder.CreateIndex(
                name: "IX_Acquisitions_ApplicationUserId",
                table: "Acquisitions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId",
                table: "User",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acquisitions_AspNetUsers_ApplicationUserId",
                table: "Acquisitions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Acquisitions_User_UserId",
                table: "Acquisitions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId2",
                table: "AspNetUserRoles",
                column: "UserId2",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_User_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Carts_CartId",
                table: "AspNetUsers",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Histories_HistoryId",
                table: "AspNetUsers",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_User_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_User_UserId",
                table: "Histories",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_ApplicationUserId",
                table: "Notifications",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_User_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acquisitions_AspNetUsers_ApplicationUserId",
                table: "Acquisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Acquisitions_User_UserId",
                table: "Acquisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId2",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_User_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Carts_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Histories_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_User_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_User_UserId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_AspNetUsers_ApplicationUserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_User_UserId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_ApplicationUserId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Histories_UserId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId2",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Acquisitions_ApplicationUserId",
                table: "Acquisitions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId2",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Acquisitions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Notifications",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Histories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Acquisitions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserId",
                table: "Histories",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Acquisitions_AspNetUsers_UserId",
                table: "Acquisitions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_AspNetUsers_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
