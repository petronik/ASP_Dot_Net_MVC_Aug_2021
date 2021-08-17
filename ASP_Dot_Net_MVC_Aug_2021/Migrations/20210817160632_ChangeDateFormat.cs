using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Dot_Net_MVC_Aug_2021.Migrations
{
    public partial class ChangeDateFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "11GER/G1",
                column: "P_InDate",
                value: new DateTime(2017, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "13-Q2/P2",
                column: "P_InDate",
                value: new DateTime(2017, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "14-Q1/L3",
                column: "P_InDate",
                value: new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1548-QQ2",
                column: "P_InDate",
                value: new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1558-QW1",
                column: "P_InDate",
                value: new DateTime(2018, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QTY",
                column: "P_InDate",
                value: new DateTime(2017, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QWE",
                column: "P_InDate",
                value: new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2238/QPD",
                column: "P_InDate",
                value: new DateTime(2018, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23109-HB",
                column: "P_InDate",
                value: new DateTime(2018, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23114-AA",
                column: "P_InDate",
                value: new DateTime(2018, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "54778-2T",
                column: "P_InDate",
                value: new DateTime(2017, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "89-WRE-Q",
                column: "P_InDate",
                value: new DateTime(2018, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "PVC23DRT",
                column: "P_InDate",
                value: new DateTime(2018, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-18277",
                column: "P_InDate",
                value: new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-23116",
                column: "P_InDate",
                value: new DateTime(2018, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "WR3/TT3",
                column: "P_InDate",
                value: new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "11GER/G1",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "13-Q2/P2",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "14-Q1/L3",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1548-QQ2",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1558-QW1",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QTY",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QWE",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2238/QPD",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23109-HB",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23114-AA",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "54778-2T",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "89-WRE-Q",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "PVC23DRT",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-18277",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-23116",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "WR3/TT3",
                column: "P_InDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2000));
        }
    }
}
