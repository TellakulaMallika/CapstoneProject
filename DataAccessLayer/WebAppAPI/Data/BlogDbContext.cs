using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAPI.Models;

namespace WebAppAPI.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAPI.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<WebAppAPI.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<WebAppAPI.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
