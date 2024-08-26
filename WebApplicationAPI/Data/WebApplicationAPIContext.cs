using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Entities;

namespace WebApplicationAPI.Data
{
    public class WebApplicationAPIContext : DbContext
    {
        public WebApplicationAPIContext (DbContextOptions<WebApplicationAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contato { get; set; } = default!;
    }
}
