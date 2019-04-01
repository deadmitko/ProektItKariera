using System;
using System.Collections.Generic;

namespace Proekt2.Models
{
    public partial class Files
    {

        public int Id { get; set; }

        public int? IdUser { get; set; }

        public string File { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Ext { get; set; }

    }
}
