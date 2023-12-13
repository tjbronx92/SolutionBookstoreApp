﻿namespace BookstoreApp.API.Models.Book
{
    public class BookDetailsDto : BaseDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public string? Isbn { get; set; }
        public string? Summary { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public int? AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
