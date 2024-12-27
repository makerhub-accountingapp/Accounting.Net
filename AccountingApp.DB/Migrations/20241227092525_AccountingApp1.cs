using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingApp.DB.Migrations
{
    /// <inheritdoc />
    public partial class AccountingApp1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_\"Account\"_\"User\"_UserId",
                table: "\"Account\"");

            migrationBuilder.DropForeignKey(
                name: "FK_\"Detail\"_\"Category\"_CategoryId",
                table: "\"Detail\"");

            migrationBuilder.DropForeignKey(
                name: "FK_\"Detail\"_\"Transaction\"_TransactionId",
                table: "\"Detail\"");

            migrationBuilder.DropForeignKey(
                name: "FK_\"Detail\"_\"TransactionType\"_TransactionTypeId",
                table: "\"Detail\"");

            migrationBuilder.DropForeignKey(
                name: "FK_\"Transaction\"_\"Account\"_AccountId",
                table: "\"Transaction\"");

            migrationBuilder.DropForeignKey(
                name: "FK_\"Transaction\"_\"Repetition\"_RepetitionId",
                table: "\"Transaction\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"User\"",
                table: "\"User\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"TransactionType\"",
                table: "\"TransactionType\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"Transaction\"",
                table: "\"Transaction\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"Repetition\"",
                table: "\"Repetition\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"Detail\"",
                table: "\"Detail\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"Category\"",
                table: "\"Category\"");

            migrationBuilder.DropPrimaryKey(
                name: "PK_\"Account\"",
                table: "\"Account\"");

            migrationBuilder.RenameTable(
                name: "\"User\"",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "\"TransactionType\"",
                newName: "TransactionType");

            migrationBuilder.RenameTable(
                name: "\"Transaction\"",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "\"Repetition\"",
                newName: "Repetition");

            migrationBuilder.RenameTable(
                name: "\"Detail\"",
                newName: "Detail");

            migrationBuilder.RenameTable(
                name: "\"Category\"",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "\"Account\"",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_\"Transaction\"_RepetitionId",
                table: "Transaction",
                newName: "IX_Transaction_RepetitionId");

            migrationBuilder.RenameIndex(
                name: "IX_\"Transaction\"_AccountId",
                table: "Transaction",
                newName: "IX_Transaction_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_\"Detail\"_TransactionTypeId",
                table: "Detail",
                newName: "IX_Detail_TransactionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_\"Detail\"_TransactionId",
                table: "Detail",
                newName: "IX_Detail_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_\"Detail\"_CategoryId",
                table: "Detail",
                newName: "IX_Detail_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_\"Account\"_UserId",
                table: "Account",
                newName: "IX_Account_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionType",
                table: "TransactionType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repetition",
                table: "Repetition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detail",
                table: "Detail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_User_UserId",
                table: "Account",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Category_CategoryId",
                table: "Detail",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_TransactionType_TransactionTypeId",
                table: "Detail",
                column: "TransactionTypeId",
                principalTable: "TransactionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Transaction_TransactionId",
                table: "Detail",
                column: "TransactionId",
                principalTable: "Transaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Account_AccountId",
                table: "Transaction",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Repetition_RepetitionId",
                table: "Transaction",
                column: "RepetitionId",
                principalTable: "Repetition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_User_UserId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Category_CategoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Detail_TransactionType_TransactionTypeId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Transaction_TransactionId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Account_AccountId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Repetition_RepetitionId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionType",
                table: "TransactionType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repetition",
                table: "Repetition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detail",
                table: "Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "\"User\"");

            migrationBuilder.RenameTable(
                name: "TransactionType",
                newName: "\"TransactionType\"");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "\"Transaction\"");

            migrationBuilder.RenameTable(
                name: "Repetition",
                newName: "\"Repetition\"");

            migrationBuilder.RenameTable(
                name: "Detail",
                newName: "\"Detail\"");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "\"Category\"");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "\"Account\"");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_RepetitionId",
                table: "\"Transaction\"",
                newName: "IX_\"Transaction\"_RepetitionId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_AccountId",
                table: "\"Transaction\"",
                newName: "IX_\"Transaction\"_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_TransactionTypeId",
                table: "\"Detail\"",
                newName: "IX_\"Detail\"_TransactionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_TransactionId",
                table: "\"Detail\"",
                newName: "IX_\"Detail\"_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_CategoryId",
                table: "\"Detail\"",
                newName: "IX_\"Detail\"_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Account_UserId",
                table: "\"Account\"",
                newName: "IX_\"Account\"_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"User\"",
                table: "\"User\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"TransactionType\"",
                table: "\"TransactionType\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"Transaction\"",
                table: "\"Transaction\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"Repetition\"",
                table: "\"Repetition\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"Detail\"",
                table: "\"Detail\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"Category\"",
                table: "\"Category\"",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_\"Account\"",
                table: "\"Account\"",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_\"Account\"_\"User\"_UserId",
                table: "\"Account\"",
                column: "UserId",
                principalTable: "\"User\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_\"Detail\"_\"Category\"_CategoryId",
                table: "\"Detail\"",
                column: "CategoryId",
                principalTable: "\"Category\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_\"Detail\"_\"Transaction\"_TransactionId",
                table: "\"Detail\"",
                column: "TransactionId",
                principalTable: "\"Transaction\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_\"Detail\"_\"TransactionType\"_TransactionTypeId",
                table: "\"Detail\"",
                column: "TransactionTypeId",
                principalTable: "\"TransactionType\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_\"Transaction\"_\"Account\"_AccountId",
                table: "\"Transaction\"",
                column: "AccountId",
                principalTable: "\"Account\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_\"Transaction\"_\"Repetition\"_RepetitionId",
                table: "\"Transaction\"",
                column: "RepetitionId",
                principalTable: "\"Repetition\"",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
