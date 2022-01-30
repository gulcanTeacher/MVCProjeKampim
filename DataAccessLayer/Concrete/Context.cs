using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Context :Dbset türündeki her şeyi sql e tablo olarak yansıtır.

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }//About sınıfın ismi Abouts tablonun ismi.About Entitiylayer da.Bu yuzden add reference deyip using System.Data.Entity; ve using EntityLayer.Concrete; ekledik.

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }

    }
}
