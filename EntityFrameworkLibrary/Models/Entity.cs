using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
