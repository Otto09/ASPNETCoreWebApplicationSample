using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebApplicationSample.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext (DbContextOptions<ClientsContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCoreWebApplicationSample.Models.Clients> Clients { get; set; }
    }
}
