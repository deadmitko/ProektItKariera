using System;
using System.Collections.Generic;

namespace ConsoleApp28.Data.Models
{
    public partial class UserUi
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Ui1 { get; set; }
        public string Ui2 { get; set; }

        public virtual Users IdUserNavigation { get; set; }
    }
}
