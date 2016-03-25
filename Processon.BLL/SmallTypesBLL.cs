using Processon.DAL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class SmallTypesBLL
    {
        DAL.SmallTypesDAL dal = new DAL.SmallTypesDAL();
         public IList<Model.SmallTypes> GetSmallTypeList()
        {
            return  dal.GetSmallTypeList();
        }
    }
}
