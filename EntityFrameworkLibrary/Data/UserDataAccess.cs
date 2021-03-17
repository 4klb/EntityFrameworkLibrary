using EntityFrameworkLibrary.Models;
using EntityFrameworkLibrary.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkLibrary.Data
{
    class UserDataAccess
    {
        public void SelectDebtors()
        {
            var draw = new Draw();

            using (var context = new LibraryContext())
            {
                var list = from user in context.User
                            join orderedBooks in context.OrderedBooks on user.Id equals orderedBooks.UserId 
                            join book in context.Book on orderedBooks.BookId equals book.Id
                            select new
                            {
                                FirstName = user.FirstName,
                                LastName = user.LastName
                            };

                draw.DrawData(list);
            }
        }

        public void DeleteAllDebtors()
        {

            using (var context = new LibraryContext())
            {
                var debtors = context.OrderedBooks.Select(user => user);

                foreach (var user in debtors)
                {
                    context.OrderedBooks.Remove(user);
                }

                context.SaveChanges();
            }
        }
    }
}
