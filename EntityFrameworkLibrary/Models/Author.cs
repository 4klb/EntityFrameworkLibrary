using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class Author : PersonalData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BookId { get; set; }
    }
}
