using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class AvailableBooks : Entity
    {
        public int Quantity { get; set; }
        public Guid BookId { get; set; }

    }
}
