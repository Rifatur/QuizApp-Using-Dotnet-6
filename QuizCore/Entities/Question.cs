using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCore.Entities;

public class Question
{
    [Key]
    public int QnId { get; set; }
    [Column(TypeName = "nvarchar(250)")]
    public string QuestionTitle { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string? ImageName { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string Option1 { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string Option2 { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string Option3 { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string Option4 { get; set; }
    public int Answer { get; set; }
    public bool IsPublish  { get; set; }


}

