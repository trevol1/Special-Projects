using System.Collections.Generic;

namespace MovieholicAPI.Models.DTO.Movie
{
    public class MovieCharactersReadDTO
    {
        // Primary Key
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }

        // Foreign Key
        public int? FranchiseId { get; set; }
        public List<int> Characters { get; set; }
    }
}