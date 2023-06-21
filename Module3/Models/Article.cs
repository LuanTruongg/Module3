﻿namespace Module3.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<ArticleSection> Sections { get; set; }
    }
}
