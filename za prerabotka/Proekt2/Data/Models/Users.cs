using System;
using System.Collections.Generic;

namespace Proekt2.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
    }
}
