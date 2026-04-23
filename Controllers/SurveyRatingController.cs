using CarRecommendationApp.Data;
using CarRecommendationApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRecommendationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyRatingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SurveyRatingController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSurveyRatings()
        {
            var surveyRating = _context.SurveyRatings.ToList();
            return Ok(surveyRating);
        }

        [HttpPost]
        public IActionResult AddSurveyRatings([FromBody] SurveyRating surveyRating)
        {
            _context.SurveyRatings.Add(surveyRating);
            _context.SaveChanges();

            return Ok(surveyRating);
        }
    }
}
