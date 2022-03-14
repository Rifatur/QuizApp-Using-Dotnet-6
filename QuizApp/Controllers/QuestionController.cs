using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizCore.Entities;
using QuizService.Interfaces;

namespace QuizApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IQuestion _Question;

    public QuestionController(IQuestion Question)
    {
        _Question = Question;
    }

    [HttpGet]   
    [Route("getall")]
    public  IActionResult GetAllRecord()
    {
        var response = _Question.GetAllQuestions();
        return Ok(response);
    }
    //Get Single Question
    [HttpGet]
    [Route("singlequestion")]
    public IActionResult GetSingleRecord(int id)
    {
        var response = _Question.GetSingleQuestion(id);
        return Ok(response);
    }

    //Add
    [HttpPost]
    [Route("addquestion")]

    public IActionResult insertQuestion(Question question)
    {
        return Ok(_Question.AddQuestion(question));
    
    }

    //Update
    [HttpPut]
    [Route("Update-Question")]
    public IActionResult UpdateQuestion(Question question)
    {
        return Ok(_Question.UpdateQuestion(question));
    }

    //Delete
    [HttpDelete]
    [Route("Delete-Question")]
    public  IActionResult DeleteQuestion(int id)
    {
        return Ok(_Question.RemoveQuestion(id));
    }



}
