using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class CashierCheck
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  C_Id{ get; set; }

        /// <summary>
        /// �Ƿ�ͬ�⣬1:ͬ�⣬0:��ͬ��
        /// <summary>
        public  int  C_IsAgreed{ get; set; }

        /// <summary>
        /// ��ע˵��
        /// <summary>
        public  string  C_Node{ get; set; }

        /// <summary>
        /// ���ʱ��
        /// <summary>
        public  DateTime  C_CheckTime{ get; set; }

    }
}
