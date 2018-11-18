using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using evaBACKEND.Models;
using Task = evaBACKEND.Models.Task;

namespace evaBACKEND.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
		

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
		}		

        public DbSet<evaBACKEND.Models.Task> Task { get; set; }

	}
}
