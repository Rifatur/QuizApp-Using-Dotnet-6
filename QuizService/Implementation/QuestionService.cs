using QuizCore.Entities;
using QuizRespo;
using QuizService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService.Implementation
{
    public class QuestionService : IQuestion
    {
        private readonly AppDbCondext _appDbContext;
        public QuestionService(AppDbCondext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Insert Question
        public string AddQuestion(Question question)
        {
            try
            {
                _appDbContext.questions.Add(question);
                _appDbContext.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _appDbContext.questions.ToList();
        }

        public Question GetSingleQuestion(int id)
        {
            return _appDbContext.questions.Where(q => q.QnId == id ).FirstOrDefault();

            //_appDbContext.questions.Find(id)
        }

        public string RemoveQuestion(int id)
        {
            try
            {
                var isQuestion = _appDbContext.questions.Where(q => q.QnId == id).FirstOrDefault();
                _appDbContext.Remove(isQuestion);
                _appDbContext.SaveChanges();
                return "Successfully Rremove";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }


        }

        public string UpdateQuestion(Question question)
        {
            try 
            {
                var Question = _appDbContext.questions.Where(q => q.QnId == question.QnId ).FirstOrDefault();
                if(Question != null)
                {
                    Question.QuestionTitle = question.QuestionTitle;
                    Question.ImageName = question.ImageName;
                    Question.Option1 = question.Option1;
                    Question.Option2 = question.Option4;
                    Question.Option3 = question.Option3;
                    Question.Option4 = question.Option4;
                    Question.Answer = question.Answer;
                    Question.IsPublish = question.IsPublish;

                    return "Update Successfully! ";
                }
                else
                {
                    return "No Data Found";
                }

            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
