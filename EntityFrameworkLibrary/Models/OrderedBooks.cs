using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class OrderedBooks : Entity
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}
