using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCCoreWithAuth.Models;

namespace MVCCoreWithAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Tbl_Book> Tbl_Books { get; set; }
        public DbSet<Tbl_AuthorAndTranslator> Tbl_AuthorsAndTranslators { get; set; }
        public DbSet<Tbl_BookCover> Tbl_BookCovers { get; set; }
        public DbSet<Tbl_BookSize> Tbl_BookSizes { get; set; }
        public DbSet<Tbl_BookSubject> Tbl_BookSubjects { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
