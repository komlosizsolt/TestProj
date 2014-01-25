using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    public class UserDBContex : DbContext 
    {
        public UserDBContex()
            : base(Properties.Settings.Default.test1ConnectionString)
        {
            Database.SetInitializer<UserDBContex>(new DropCreateDatabaseIfModelChanges<UserDBContex>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().HasKey(x => x.Id);

                base.OnModelCreating(modelBuilder);
        }
    }
}
