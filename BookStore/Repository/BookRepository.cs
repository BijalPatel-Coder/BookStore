using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource().ToList();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel{id=1,Author="Bijal",Title="MVC Book"},
                new BookModel{id=2,Author="Bijal",Title="c# Book"},
                new BookModel{id=3,Author="Piyush",Title="AutoMobileBook"},
                new BookModel{id=4,Author="Kenisha",Title="CraftBook"},
                 new BookModel{id=5,Author="Kenisha",Title="FictionStories"},
            };
        }
    }
}
