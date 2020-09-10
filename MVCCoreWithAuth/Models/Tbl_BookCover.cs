using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWithAuth.Models
{
    public class Tbl_BookCover
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Tbl_Book> Books { get; set; }
    }
}
