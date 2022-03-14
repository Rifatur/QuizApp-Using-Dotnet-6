using QuizCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService.Interfaces
{
    public interface IQuestion
    {
        //Get All Reacord
        IEnumerable<Question> GetAllQuestions();
        //Get Single Reacord
        Question GetSingleQuestion(int id);
        //Add  Reacord
        string AddQuestion(Question question);
        //Update Reacord
        string UpdateQuestion(Question question);
        //Delete Reacord
        string RemoveQuestion(int id);
    }
}
