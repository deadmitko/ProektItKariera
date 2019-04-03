using System;
using System.Collections.Generic;

namespace ConsoleApp28.Data.Models
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Favourites = new HashSet<Favourites>();
            Personals = new HashSet<Personals>();
            Receipts = new HashSet<Receipts>();
            UserUi = new HashSet<UserUi>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Favourites> Favourites { get; set; }
        public virtual ICollection<Personals> Personals { get; set; }
        public virtual ICollection<Receipts> Receipts { get; set; }
        public virtual ICollection<UserUi> UserUi { get; set; }
    }
}
