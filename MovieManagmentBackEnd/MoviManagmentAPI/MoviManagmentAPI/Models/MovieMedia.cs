using MoviManagmentAPI.Generic;

namespace MoviManagmentAPI.Models
{
    public class MovieMedia: GenericModel
    {
        public int Id { get; set; }
        public string? MediaPath { get; set; }
        public int MoviedId { get; set; }
        public Movie? Movie { get; set; }
        
    }
}
