using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AthletsLibrary;

namespace WpfApp1
{
    internal class AppContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Athlet> Athlets { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
