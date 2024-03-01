using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAPI.Models;

namespace WebAppAPI.Data
{
    public class BlockDbContext : DbContext
    {
        public BlockDbContext (DbContextOptions<BlockDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAPI.Models.AdminInfo> AdminInfo { get; set; } = default!;
    }
}
