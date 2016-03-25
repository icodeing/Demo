using Processon.DAL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class BigTypesBLL
    {
        BigTypesDAL dal = new BigTypesDAL();
        public IList<BigTypes> GetBigTypeList()
        {
            return dal.GetBigTypeList();
        }
    }
}
