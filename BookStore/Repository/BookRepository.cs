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
                new BookModel{id=1,Author="Bijal",Title="MVC Book", Description="This is a description for MVC Book",Category="Programming",Language="English",TotalPages=349},
                new BookModel{id=2,Author="Bijal",Title="c# Book",Description="This is a description for c# Book",Category="Developer",Language="English",TotalPages=587},
                new BookModel{id=3,Author="Piyush",Title="AutocadBook",Description="This is a description for Autocad Book",Category="Designing",Language="English",TotalPages=750},
                new BookModel{id=4,Author="Kenisha",Title="CraftBook",Description="This is a description for Craft Book",Category="Entertainment",Language="Hindi",TotalPages=150},
                new BookModel{id=5,Author="Kenisha",Title="FictionStories",Description="This is a description for Fiction Book",Category="Entertainment",Language="Hindi",TotalPages=231},
                new BookModel{id=5,Author="TechyClimate",Title="Azure DevOps",Description="This is a description for Azure DevOps Book",Category="Programming",Language="English",TotalPages=684},
            };
        }
    }
}
