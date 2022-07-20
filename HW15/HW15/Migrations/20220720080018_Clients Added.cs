using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW15.Migrations
{
    public partial class ClientsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Projects_ProjectId1",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId1",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "Client");

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "FirstName", "LastName", "ProjectId" },
                values: new object[,]
                {
                    { 1, "test1", "test", 1 },
                    { 2, "test2", "test", 2 },
                    { 3, "test3", "test", 3 },
                    { 4, "test4", "test", 4 },
                    { 5, "test5", "test", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 0, 18, 69, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 0, 18, 69, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 0, 18, 69, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 0, 18, 69, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 0, 18, 69, DateTimeKind.Local).AddTicks(2058));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId1",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 9, 58, 24, 504, DateTimeKind.Local).AddTicks(4281));

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
    }
}
