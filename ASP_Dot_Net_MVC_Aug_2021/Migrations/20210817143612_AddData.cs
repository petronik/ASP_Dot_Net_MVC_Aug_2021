﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Dot_Net_MVC_Aug_2021.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_Code", "P_Discount", "P_InDate", "P_Min", "P_Price", "P_QOH", "P_descript", "V_code" },
                values: new object[,]
                {
                    { "23114-AA", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015), 5, 14.4, 8, "Sledge hammer, 12 lb.", null },
                    { "PVC23DRT", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), 75, 5.8700000000000001, 188, "PVC pipe, 3.5-in, 8-ft", null }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "V_code", "V_AreaCode", "V_contact", "V_name", "V_order", "V_phone", "V_state" },
                values: new object[,]
                {
                    { 21225, 615, "Smithson", "Bryson, Inc", "Y", "223-3234", "TN" },
                    { 21226, 904, "Flushing", "SuperLoo, Inc", "N", "215-8995", "FL" },
                    { 21231, 615, "Singh", "D&E Supply", "Y", "228-3245", "TN" },
                    { 21344, 615, "Singh", "Gomez Bros.", "N", "889-2546", "KY" },
                    { 22567, 901, "Smith", "Dome Supply", "N", "878-1419", "GA" },
                    { 23119, 901, "Anderson", "Randset Ltd.", "Y", "678-3998", "GA" },
                    { 24004, 615, "Brownling", "Brackman Bros.", "N", "228-1410", "TN" },
                    { 24288, 615, "Hakford", "ORDVA, Inc.", "Y", "898-1234", "TN" },
                    { 25443, 904, "Smith", "B&K, Inc.", "N", "227-0093", "FL" },
                    { 25501, 615, "Smythe", "Damal Supplies", "N", "890-3529", "TN" },
                    { 25595, 904, "Orton", "Rubicon Systems", "Y", "456-0092", "FL" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_Code", "P_Discount", "P_InDate", "P_Min", "P_Price", "P_QOH", "P_descript", "V_code" },
                values: new object[,]
                {
                    { "23109-HB", 0.10000000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), 10, 9.9499999999999993, 23, "Claw hammer", 21225 },
                    { "SM-18277", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014), 75, 6.9900000000000002, 172, "1.25-in. metal screw, 25", 21225 },
                    { "SM-23116", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1992), 100, 8.4499999999999993, 237, "2.5-in. wd screw, 50", 21231 },
                    { "13-Q2/P2", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1992), 15, 14.99, 32, "7.25-in pwr. saw blade", 21344 },
                    { "14-Q1/L3", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993), 12, 17.489999999999998, 18, "9.00-in pwr. saw blade", 21344 },
                    { "54778-2T", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), 20, 4.9900000000000002, 43, "Rat-tail file, 1/8-in. fine", 21344 },
                    { "1548-QQ2", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002), 8, 39.950000000000003, 15, "Hrd. cloth, 1/4-in., 2x50", 23119 },
                    { "1558-QW1", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2002), 5, 43.990000000000002, 23, "Hrd. cloth, 1/2-in., 1x50", 23119 },
                    { "2232/QTY", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), 5, 109.92, 8, "B&D jigsaw, 12-in. blade", 24288 },
                    { "2232/QWE", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1981), 5, 99.870000000000005, 6, "B&D jigsaw, 8-in. blade", 24288 },
                    { "89-WRE-Q", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009), 5, 256.99000000000001, 11, "Hicut chain saw, 16 in.", 24288 },
                    { "11GER/G1", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003), 5, 109.98999999999999, 8, "Power painter, 15 psi., 3-nozzle", 25595 },
                    { "2238/QPD", 0.050000000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1997), 5, 38.950000000000003, 12, "B&D cordless drill, 12-in", 25595 },
                    { "WR3/TT3", 0.10000000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2000), 5, 119.95, 18, "Steel matting, 4x8x1/6, .5 mesh", 25595 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "11GER/G1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "13-Q2/P2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "14-Q1/L3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1548-QQ2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "1558-QW1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QTY");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2232/QWE");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "2238/QPD");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23109-HB");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "23114-AA");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "54778-2T");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "89-WRE-Q");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "PVC23DRT");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-18277");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "SM-23116");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "P_Code",
                keyValue: "WR3/TT3");

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 21226);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 22567);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 24004);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 25443);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 25501);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 21225);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 21231);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 21344);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 23119);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 24288);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "V_code",
                keyValue: 25595);
        }
    }
}
