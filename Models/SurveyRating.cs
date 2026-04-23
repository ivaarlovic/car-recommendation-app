namespace CarRecommendationApp.Models
{
    public class SurveyRating
    {
        public int Id { get; set; }
        public int SurveyUserId { get; set; }
        public int CarId { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
