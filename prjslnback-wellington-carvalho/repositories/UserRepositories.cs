using prjslnback_wellington_carvalho.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prjslnback_wellington_carvalho.repositories
{
    public class UserRepositories
    {
        public static User Get(String username, string password) 
        {
            var users = new List<User>();
            users.Add(new User { id = 1, userName = "Joao", password = "123" });
            users.Add(new User { id = 2, userName = "Maria", password = "234" });
            return users.Where(x => x.userName == username && x.password == password).FirstOrDefault();
        }     
    }

}
