using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class MoneyManagementCheck
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  M_Id{ get; set; }

        /// <summary>
        /// �Ƿ�ͬ�⣬1:ͬ�⣬0:��ͬ��
        /// <summary>
        public  int  M_IsAgreed{ get; set; }

        /// <summary>
        /// ��ע˵��
        /// <summary>
        public  string  M_Node{ get; set; }

        /// <summary>
        /// ���ʱ��
        /// <summary>
        public  DateTime  M_CheckTime{ get; set; }

    }
}
