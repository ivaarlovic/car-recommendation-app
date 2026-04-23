using CarRecommendationApp.Data;
using CarRecommendationApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRecommendationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyUserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SurveyUserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSurveyUsers()
        {
            var surveyUsers = _context.SurveyUsers.ToList();
            return Ok(surveyUsers);
        }

        [HttpPost]
        public IActionResult AddSurveyUsers([FromBody] SurveyUser surveyUser)
        {
            _context.SurveyUsers.Add(surveyUser);
            _context.SaveChanges();

            return Ok(surveyUser);
        }
    }
}
