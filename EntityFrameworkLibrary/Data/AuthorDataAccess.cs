using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using EntityFrameworkLibrary.Models;
using EntityFrameworkLibrary.UI;

namespace EntityFrameworkLibrary.Data
{
    public class AuthorDataAccess
    {
        public void SelectAuthorsByBook(string bookName)
        {
            var draw = new Draw();

            using (var context = new LibraryContext())
            {
                var list = context.Author.Join(context.Book.Where(book => book.Name == bookName),
                    author => author.BookId,
                    book => book.Id,
                    (author, book) => new 
                    {
                        LastName = author.LastName

                    }).ToList();

                draw.DrawData(list);
            }
        }
    }
}
