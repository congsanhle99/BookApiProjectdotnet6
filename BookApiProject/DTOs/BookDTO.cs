﻿namespace BookApiProject.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public DateTime? DatePublished { get; set; }
    }
}
