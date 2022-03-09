using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProject.Data
{
    public class User : IdentityUser
    {
       
       
        public string Fullname { get; set; }
        
      

        public RoleType Role { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

    }
}
