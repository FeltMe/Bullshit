using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace Bullshit.Db
{
    class MyAccounst : DbContext
    {
        public DbSet<User> Users { get; set; }
        public MyAccounst() : base(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString)
        {

        }
    }
}
