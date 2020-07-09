using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Models.ViewModels
{
    public class UsersDto
    {
        public UsersDto(Users users)
        {
            Username = users.Username;
            Password = users.Password;
            Name = users.Name;
            //GivenName = users.GivenName;
            //FamilyName = users.FamilyName;
            Email = users.Email;
            EmailVerified = users.EmailVerified;
            WebSite = users.WebSite;
            Address = users.Address;
            PhoneNumber = users.PhoneNumber;
            DateOfBirth = users.DateOfBirth;
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
    }
}
