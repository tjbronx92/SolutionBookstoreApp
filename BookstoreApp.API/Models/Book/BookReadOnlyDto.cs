﻿namespace BookstoreApp.API.Models.Book
{
    public class BookReadOnlyDto
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
