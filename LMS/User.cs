using System;

namespace LMS
{
    public class User
    {
        public Boolean adminPrivilege { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        //var user = new User() { name = "", password = "", username = "", adminPrivilege = false };
        //public User()
        //{
        //    adminPrivilege = false;
        //    name = "";
        //    username = "";
        //    password = "";
        //}
    }
}
