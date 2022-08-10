using prjslnback_wellington_carvalho.Data;
using prjslnback_wellington_carvalho.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prjslnback_wellington_carvalho.repositories
{
    public class UserRepositories
    {
        private DataContext _context;
        public UserRepositories(DataContext context)
        {
                   _context = context;
            _context.Add(new User { id = 1, userName = "José", password = "teste" });
            _context.Add(new User { id = 2, userName = "Maria", password = "batata" });
        }
        public static User Get(String username, string password) 
        {
            var usrList = await context.
            return userList.Where(x => x.userName == username && x.password == password).FirstOrDefault();
        }

        public static List<User> GenerateUserList() 
        {
            var users = new List<User>();
            users.Add(new User { id = 1, userName = "José", password = "teste" });
            users.Add(new User { id = 2, userName = "Maria", password = "batata" });
            return users;
        }

        public void insertUser(string username, string password) 
        {
            GenerateUserList();
        }          
    }

}
