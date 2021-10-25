using AspCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApi.Context
{
    public class AspCoreContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public AspCoreContext(DbContextOptions<AspCoreContext>options): base(options)
        {}
    }
}
