using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core
{
    public class Context : DbContext
    {
        public Context() : base("InventoryConnection")
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
