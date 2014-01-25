using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProj;
using System.Data.Entity;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDatabase()
        {
            using (var contex= new UserDBContex())
            {
                contex.Database.CreateIfNotExists();
                contex.Database.Initialize(true);
            }
        }
        [TestMethod]
        public void addUser()
        {
            UserDBContex db = new UserDBContex();

            db.Users.Add(new User() { Age=23, Name="sssss"});
            db.Orders.Add(new Order() { Cost=100, Count=3, Name="sdderf2"});
            db.SaveChanges();

        }

    }
}
