using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using saleswebmvc.Models;

namespace saleswebmvc.Data
{
    public class saleswebmvcContext : DbContext
    {
        public saleswebmvcContext (DbContextOptions<saleswebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<saleswebmvc.Models.Department> Department { get; set; } = default!;
    }
}
