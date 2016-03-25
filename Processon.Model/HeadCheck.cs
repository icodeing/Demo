using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class HeadCheck
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  H_Id{ get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public  int  H_IsAgreed{ get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public  string  H_Node{ get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public  DateTime  H_CheckTime{ get; set; }

    }
}
