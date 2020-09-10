using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWithAuth.Models
{
    public class Tbl_AuthorAndTranslator
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public ICollection<Tbl_Book> AuthorBooks { get; set; }
        //public ICollection<Tbl_Book> TranslatrBooks { get; set; }
    }
}
