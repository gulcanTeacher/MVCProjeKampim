using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AuthorRepository : IAuthorDal
    {
        public void Delete(Author p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Author p)
        {
            throw new NotImplementedException();
        }

        public List<Author> List()
        {
            throw new NotImplementedException();
        }

        public List<Author> List(Expression<Func<Author, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Author p)
        {
            throw new NotImplementedException();
        }
    }
}
