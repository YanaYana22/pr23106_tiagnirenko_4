using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr23106_tiagnirenko_4.Entity
{
        public class MyDbContext : DbContext
        {
            public DbSet<Group> Groups { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=10.137.203.94,1433;Initial Catalog=23.106-16-RK2025;User ID=23.106-exam-16;Password=Passw0rd;");
            }
        }
    }
