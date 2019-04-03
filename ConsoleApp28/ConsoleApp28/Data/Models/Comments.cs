using System;
using System.Collections.Generic;

namespace ConsoleApp28.Data.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public int? ReceiptId { get; set; }
        public string Text { get; set; }

        public virtual Users Author { get; set; }
        public virtual Receipts Receipt { get; set; }
    }
}
