using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Pastelaria2.Classes
{
    public class Pastelaria2Dbcontext : DbContext
    {
        public DbSet <Pastel> Pasteis { get; set; }
        public DbSet <Hamburger> Hamburgers { get; set; }
    }
}
