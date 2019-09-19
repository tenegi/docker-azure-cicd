using System;
using System.Collections.Generic;
using System.Linq;
using webapp.Models;

namespace webapp.Repositories
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "Waht is Lorem Ipsum?",
                Author = "Lyndon Hills",
                PublishedOn =  new DateTime(2019, 04, 01),
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
        };
        public List<Article> GetLatest()
        {
            return articles;
        }
    }
}