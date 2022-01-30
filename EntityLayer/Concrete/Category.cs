using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryDescription { get; set; }

       
        public bool CategorySatatus  { get; set; }//Category tablosundan bir kayıt silindiğinde ona bağlı olan diğer kayıtlar da silinmesin diye silmiyoruz pasife alıyoruz.


        public ICollection<Heading> Headings { get; set; }
    }
}
