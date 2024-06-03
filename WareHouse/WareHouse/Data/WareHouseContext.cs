using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WareHouse.Models;

namespace WareHouse.Data
{
    public class WareHouseContext : DbContext
    {
        public WareHouseContext (DbContextOptions<WareHouseContext> options)
            : base(options)
        {
        }

        public DbSet<WareHouse.Models.Product> Product { get; set; } = default!;
    }
}
