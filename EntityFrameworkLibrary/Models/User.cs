using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.Models
{
    public class User : PersonalData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool IsRegistered { get; set; }
    }
}
