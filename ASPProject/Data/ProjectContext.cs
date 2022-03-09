using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProject.Data
{
    public class ProjectContext: IdentityDbContext<IdentityUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }
    
  
            public  DbSet<Trophy> Trophys { get; set; }
            public  DbSet<Repertoire> Repertories { get; set; }
            public  DbSet<Message> Messages { get; set; }
            public  DbSet<News> Newes { get; set; }
        
    }
}
