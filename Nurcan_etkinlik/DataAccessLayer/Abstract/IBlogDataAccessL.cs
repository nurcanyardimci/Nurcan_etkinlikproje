using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDataAccessL : IGenericDataAccessL<Blog>
    {
        List<Blog> GetListWithCategory ();
    }
}
