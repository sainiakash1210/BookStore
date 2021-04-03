using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel>GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string titlenames, string authorNames)
        {
            return DataSource().Where(x => x.title.Contains(titlenames) || x.Author.Contains(authorNames)).ToList();
        }
            
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
               new BookModel() {Id=1, title="MVC",  Author="Akash" },
                new BookModel() {Id=2, title="PHP",  Author="Pratima" },
                 new BookModel() {Id=3, title="TESTING",  Author="Shobhit" },
                  new BookModel() {Id=4, title="SQL",  Author="Sonal" },
            };
        }
    }
}
