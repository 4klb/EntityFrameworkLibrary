using EntityFrameworkLibrary.Models;
using EntityFrameworkLibrary.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkLibrary.Data
{
    class BookDataAccess
    {
        public void SelectBooksByUser(Guid userId)
        {
            var draw = new Draw();

            using (var context = new LibraryContext())
            {
                var list = context.Book.Join(context.OrderedBooks.Where(book=>book.UserId == userId),
                book => book.Id,
                orderedBooks => orderedBooks.BookId,
                (book, orderedBooks) => new
                {
                    Name = book.Name

                }).ToList();

                draw.DrawData(list);
            }
        }


        public void SelectAvailableBooks()
        {
            var draw = new Draw();

            using (var context = new LibraryContext())
            {
                var list = context.Book.Join(context.AvailableBooks.Where(book => book.Quantity > 0),
                book => book.Id, 
                availableBooks => availableBooks.BookId,
                (book,availableBooks) => new
                {
                    Name = book.Name

                }).ToList();

                draw.DrawData(list);
            }
        }
    }
}