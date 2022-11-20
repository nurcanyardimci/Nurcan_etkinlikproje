using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfActivityRepository : GenericRepository<Activity>, IActivityDataAccessL
    {
        public System.Diagnostics.Activity GetById(int id) => throw new NotImplementedException();
        public List<System.Diagnostics.Activity> ListAllActivity() => throw new NotImplementedException();
    }
}
