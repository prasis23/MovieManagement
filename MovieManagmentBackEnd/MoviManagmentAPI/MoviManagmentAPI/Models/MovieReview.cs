namespace MoviManagmentAPI.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
        public string? Comments { get; set; }
        public string? UserId { get; set; }
        public string? MovieId { get; set;}
        public Movie? Movie { get; set; }


    } 
}
