using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity = EntityLayer.Concreate.Activity;

namespace DataAccessLayer.Abstract
{
    public interface IActivityDataAccessL : IGenericDataAccessL<Activity>
    {
        System.Diagnostics.Activity GetById(int id);
        List<System.Diagnostics.Activity> ListAllActivity();
    }
}
