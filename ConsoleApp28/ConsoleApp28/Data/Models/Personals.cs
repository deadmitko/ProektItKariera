using System;
using System.Collections.Generic;

namespace ConsoleApp28.Data.Models
{
    public partial class Personals
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Users IdUserNavigation { get; set; }
    }
}
