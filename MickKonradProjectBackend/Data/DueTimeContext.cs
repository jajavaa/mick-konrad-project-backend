using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MickKonradProjectBackend.Models
{
    public class DueTimeContext : DbContext
    {
        public DueTimeContext(DbContextOptions<DueTimeContext> options)
            : base(options)
        {
        }

        public DbSet<DueTime> dueTime { get; set; }
    }
}
