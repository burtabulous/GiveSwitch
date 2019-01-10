using System;
using System.Collections.Generic;
using System.Text;

namespace GiveSwitch.Data.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public string UserHandle { get; set; }
  
    }
}
