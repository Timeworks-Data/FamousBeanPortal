using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamousBeanPortal.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Locations { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }

    }
}
