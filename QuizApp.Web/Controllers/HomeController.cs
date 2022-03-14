using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuizApp.Web.Models;
using QuizCore.Entities;
using System.Diagnostics;

namespace QuizApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Question> questions = new List<Question>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7234/");
            HttpResponseMessage response = await client.GetAsync("api/Question/getall");
            if (response.IsSuccessStatusCode)
            {
                var result=response.Content.ReadAsStringAsync().Result;
                questions = JsonConvert.DeserializeObject<List<Question>>(result);  
            }
            return View(questions);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}