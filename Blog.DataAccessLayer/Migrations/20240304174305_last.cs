using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b7f33d85-8e1b-4929-98a0-526d1c036b51"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 466, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d478c1cb-8ae7-4b67-b7b7-98a476d5db53"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 466, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("051f3b3b-eb13-488b-a4bf-387761ea91b0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2111848-cd6c-4092-9a61-faddaa363bf0", "AQAAAAIAAYagAAAAEFSMKcrPezln4DPJPDt4zqfkE1eXlpOtnmdxIffcQ8M4gyzJnRGzedamKcjP6l/JvA==", "8298901f-8001-4936-ae07-b2c341d96cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("face5fe3-2da2-408a-97a6-d5ca1fd7faf5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40410522-4d3f-4411-96ca-ffdde69f930b", "AQAAAAIAAYagAAAAEDLHyKBJYS6Io/BaOEQUkRy3OW/Pd445LqXuyLLjFA3CgU1iGB5VrRAeecBj31hr7A==", "0df71ce6-3a46-42b2-88ee-0eae84018228" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f8b18ee-5e24-4a12-8b55-d28ea244ac44"),
                column: "ConcurrencyStamp",
                value: "ba502d63-8213-4b5e-960a-2eead1dad8b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d2bcef0-df30-432a-812c-576447066440"),
                column: "ConcurrencyStamp",
                value: "225b19d9-a651-4048-a974-477737017144");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dd891e4b-016c-4e33-81df-cc4bb161c918"),
                column: "ConcurrencyStamp",
                value: "2867540c-5433-43a7-ae14-cca0bc2cf7fc");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e9bce48-0f9b-4f4f-a3f8-09d872750f67"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 467, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9bc9a71-2dc1-48b5-ae97-237f4b23c754"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 467, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 467, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b04304e7-124a-4f5b-a472-07eb717d7a8c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 20, 43, 4, 467, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b7f33d85-8e1b-4929-98a0-526d1c036b51"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d478c1cb-8ae7-4b67-b7b7-98a476d5db53"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("051f3b3b-eb13-488b-a4bf-387761ea91b0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cface6f0-8bc4-455b-be9f-6089ed16cf80", "AQAAAAIAAYagAAAAEH0m/MMpL4u3+4Y7sYK2+G1nEx6tF6UPR+jp05aP0mfgLO7Bhof64spCaW5kgz34gw==", "6d7a84db-28fc-4d15-b3c7-8219c84af364" });

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("face5fe3-2da2-408a-97a6-d5ca1fd7faf5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d16e5bdb-dedd-4c8b-bd8b-736abf243328", "AQAAAAIAAYagAAAAEHSIYM7/ouo/OZSyZ2oafovqezxRIjFMh9PVEdqC+u0aKNHe63Y4Q/rvT8Zmr6ujgQ==", "61ec7a46-935c-47a6-a57f-8416967ee999" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f8b18ee-5e24-4a12-8b55-d28ea244ac44"),
                column: "ConcurrencyStamp",
                value: "a8fba853-bab3-48e1-b8e8-193d37f1fa60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d2bcef0-df30-432a-812c-576447066440"),
                column: "ConcurrencyStamp",
                value: "82978e49-3272-4ef3-8227-cfd4be45554d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dd891e4b-016c-4e33-81df-cc4bb161c918"),
                column: "ConcurrencyStamp",
                value: "dac4a645-dc25-446f-8c6f-7be20675e71f");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e9bce48-0f9b-4f4f-a3f8-09d872750f67"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9bc9a71-2dc1-48b5-ae97-237f4b23c754"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b04304e7-124a-4f5b-a472-07eb717d7a8c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 43, 40, 235, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
