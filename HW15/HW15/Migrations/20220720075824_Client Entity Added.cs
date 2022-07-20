using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW15.Migrations
{
    public partial class ClientEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Projects_ProjectId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId1",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 100.0m, 1, "test1", new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4268) },
                    { 2, 100.0m, 2, "test2", new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4279) },
                    { 3, 100.0m, 3, "test3", new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4280) },
                    { 4, 100.0m, 4, "test4", new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4281) },
                    { 5, 100.0m, 5, "test5", new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4281) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_ProjectId1",
                table: "Client",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Projects_ProjectId1",
                table: "Client",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Projects_ProjectId1",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId1",
                table: "Client");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "Client");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ProjectId",
                table: "Client",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Projects_ProjectId",
                table: "Client",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
