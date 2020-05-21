using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CommuNeedy.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }

        public ICollection<Need> Needs { get; set; }
    }
}
