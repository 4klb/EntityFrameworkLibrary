using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public DateTime PublicationDate { get; set; }

        //public Guid AuthorId { get; set; }
    }
}
