using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Be;
using static Be.Users;

namespace Dal
{

    public class DB : IdentityDbContext<UserApp>
    {

        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DB()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DiGiDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }



        public DbSet<Beusers> users { set; get; }
        public DbSet<Products.Product> products { set; get; }
        public DbSet<Products.Factor> factors { set; get; }
        public DbSet<Products.prodFactor> fctorprod { set; get; }
       


    }
}
