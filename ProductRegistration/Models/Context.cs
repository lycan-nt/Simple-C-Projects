using ProductRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    public class Context : DbContext
    {

        public DbSet<Product> Product { get; set; }

    }
}
