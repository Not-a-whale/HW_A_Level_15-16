using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW15.Migrations
{
    public partial class ProjectIdrequiredAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
