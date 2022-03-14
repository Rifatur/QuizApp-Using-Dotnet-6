using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizRespo.MigrationFiles
{
    public partial class Question_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    QnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Answer = table.Column<int>(type: "int", nullable: false),
                    IsPublish = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.QnId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "questions");
        }
    }
}
