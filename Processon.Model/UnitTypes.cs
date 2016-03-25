using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class UnitTypes
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  UnitId{ get; set; }

        /// <summary>
        /// 单位类型，如:个，只
        /// <summary>
        public  string  UnitName{ get; set; }

        /// <summary>
        /// 创建时间
        /// <summary>
        public  DateTime  CreateTime{ get; set; }

        /// <summary>
        /// 
        /// <summary>
        public  int  SortId{ get; set; }

    }
}
