using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b7f33d85-8e1b-4929-98a0-526d1c036b51"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d478c1cb-8ae7-4b67-b7b7-98a476d5db53"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("051f3b3b-eb13-488b-a4bf-387761ea91b0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04a0b76-6d65-4821-83a5-f05c81b8f2ff", "AQAAAAIAAYagAAAAEGok7+lU6EQvjD01Nn0m3BP7oVL7Vq41Hkrw9IxoEry76TPSMeozZz0IAo5CIPJoPA==", "fc299a01-4c1f-4f3f-b58c-1ff4127ff77b" });

            migrationBuilder.UpdateData(
                table: "AspNetAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("face5fe3-2da2-408a-97a6-d5ca1fd7faf5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f10021-a672-416a-9ddc-a905f26b8442", "AQAAAAIAAYagAAAAEIBQmVYPpcTqA+qlpaAXSChoqj9RxCVA87g7iMrcUdPTGKy1adkeRn+G5QN15GzZzQ==", "f8c418ba-4463-4954-b543-b152715fe88a" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f8b18ee-5e24-4a12-8b55-d28ea244ac44"),
                column: "ConcurrencyStamp",
                value: "f16c3853-2176-4269-a584-f9e4235cb15c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d2bcef0-df30-432a-812c-576447066440"),
                column: "ConcurrencyStamp",
                value: "e694de92-ece7-4f28-b948-ea85bab5ca86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dd891e4b-016c-4e33-81df-cc4bb161c918"),
                column: "ConcurrencyStamp",
                value: "feeb66e9-cb6b-4e1e-ab8c-88ba6e88e702");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e9bce48-0f9b-4f4f-a3f8-09d872750f67"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9bc9a71-2dc1-48b5-ae97-237f4b23c754"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a72bd43f-6c8d-49c4-b62c-ea7a18f0a9a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b04304e7-124a-4f5b-a472-07eb717d7a8c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 11, 41, 53, 348, DateTimeKind.Local).AddTicks(3755));
        }
    }
}
