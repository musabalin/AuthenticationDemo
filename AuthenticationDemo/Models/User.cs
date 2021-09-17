using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationDemo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
    public class UserInit
    {
        public static List<User> Init()
        {

            return new List<User> {
            new User { ID = 1,Username="Admin",Password="123",Role=0 } ,
            new User { ID = 2,Username="admin",Password="123",Role=1 }
        };
        }
    }
}