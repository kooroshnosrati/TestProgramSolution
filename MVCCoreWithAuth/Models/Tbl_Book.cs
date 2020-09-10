using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWithAuth.Models
{
    public class Tbl_Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public int SizeID { get; set; }
        [Column(TypeName = "money")]
        public decimal Fi { get; set; }
        public int SubjectID { get; set; }
        public string Image { get; set; }
        public int CoverID { get; set; }
        public long ISBN { get; set; }
        public System.DateTime ReleasedDate { get; set; }
        public System.DateTime PublishedDate { get; set; }
        public Nullable<int> circulation { get; set; }
        public bool IsTranslated { get; set; }


        public int AuthorID { get; set; }
        public Tbl_AuthorAndTranslator Tbl_AuthorAndTranslator { get; set; }
        //public int TranslatorID { get; set; }
        //public Tbl_AuthorAndTranslator Tbl_AuthorAndTranslator1 { get; set; }
        public Tbl_BookSize Tbl_BookSize { get; set; }
        public Tbl_BookSubject Tbl_BookSubject { get; set; }
        public Tbl_BookCover Tbl_BookCover { get; set; }

    }
}
