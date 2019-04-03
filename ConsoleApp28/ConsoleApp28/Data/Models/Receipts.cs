using System;
using System.Collections.Generic;

namespace ConsoleApp28.Data.Models
{
    public partial class Receipts
    {
        public Receipts()
        {
            Comments = new HashSet<Comments>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AuthorId { get; set; }
        public string Category { get; set; }

        public virtual Users Author { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
