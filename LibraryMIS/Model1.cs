using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibraryMIS
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BookInfo> BookInfo { get; set; }
        public virtual DbSet<bookOut> bookOut { get; set; }
        public virtual DbSet<BookType> BookType { get; set; }
        public virtual DbSet<Borrow> Borrow { get; set; }
        public virtual DbSet<manager> manager { get; set; }
        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<ReaderInfo> ReaderInfo { get; set; }
        public virtual DbSet<ReaderType> ReaderType { get; set; }
        public virtual DbSet<Return> Return { get; set; }
        public virtual DbSet<type> type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
