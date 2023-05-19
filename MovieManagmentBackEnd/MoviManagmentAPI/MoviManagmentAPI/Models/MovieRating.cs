using MoviManagmentAPI.Generic;

namespace MoviManagmentAPI.Models
{
    public class MovieRating:GenericModel
    {
        public int Id { get; set; }
        public Decimal Rating  { get; set; }    
        public string? UserId { get; set; }
        public int MovieId { get; set; }
       

    }
}
