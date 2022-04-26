#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUT.Models;

namespace CRUT.Data
{
    public class CRUTContext : DbContext
    {
        public CRUTContext (DbContextOptions<CRUTContext> options)
            : base(options)
        {
        }

        public DbSet<CRUT.Models.Coin> Coin { get; set; }
    }
}
