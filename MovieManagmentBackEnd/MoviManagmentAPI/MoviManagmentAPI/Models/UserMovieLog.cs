using MoviManagmentAPI.Generic;

namespace MoviManagmentAPI.Models
{
    public class UserMovieLog:GenericModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
