namespace AspNetCoreWebApi6.Models
{
    public class Movie
    {
        public int Id { get; set; } //The Id field is required by the database for the primary key.
        public string? Title { get; set; }

        public string? Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}
