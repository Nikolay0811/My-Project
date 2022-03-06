using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProject.Data
{
    public class ProjectContext: DbContext
    {
       
        
            public ProjectContext()
            {

            }
            public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
            {

            }

            public virtual DbSet<User> Users { get; set; }
            public virtual DbSet<Trophy> Trophys { get; set; }
            public virtual DbSet<Repertoire> Repertories { get; set; }
            public virtual DbSet<Message> Messages { get; set; }
            public virtual DbSet<News> Newes { get; set; }
        
    }
}
