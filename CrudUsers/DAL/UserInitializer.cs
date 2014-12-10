using CrudUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudUsers.DAL
{
    public class UserInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{FirstName ="Oliver", LastName="Rosales", Email="jrosales@village88.com"},
                new User{FirstName="KB", LastName="Tonel", Email="kbtonel@village88.com"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}