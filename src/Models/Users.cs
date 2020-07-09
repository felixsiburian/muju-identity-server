using IdentityServer4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4.Models
{
    public class Users : EntitySoftDelete
    {
        public Users(Guid id) : base(id)
        {
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        //public string Country { get; set; }
        //public string Province { get; set; }
        //public string City { get; set; }
        //public string PostalCode { get; set; }


    }
}
