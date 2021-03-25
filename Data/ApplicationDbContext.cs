using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace persona_ciudad.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Ubicacion> Ubicaciones {get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
