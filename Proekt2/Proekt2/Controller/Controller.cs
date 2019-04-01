using Proekt2.Data.Models;
using Proekt2.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt2.Controller
{
    public class Controller
    {
        private proektContext db;
        public Controller()
        {
            db = new proektContext();
            
        }
        public static void register(string username,string password,string first,string last,string email)
        {
            
            db.Users.Add();



        }






        }
}
