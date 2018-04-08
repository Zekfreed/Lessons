using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TraineeManagement.Migrations
{
    public partial class traineesWithProfession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TraineeshipId",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_ProfessionId",
                table: "Trainees",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Professions_ProfessionId",
                table: "Trainees",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Professions_ProfessionId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_ProfessionId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "TraineeshipId",
                table: "Trainees");
        }
    }
}
