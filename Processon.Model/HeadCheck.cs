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
        /// �Ƿ�ͬ�⣬1:ͬ�⣬0:��ͬ��
        /// <summary>
        public  int  H_IsAgreed{ get; set; }

        /// <summary>
        /// ��ע˵��
        /// <summary>
        public  string  H_Node{ get; set; }

        /// <summary>
        /// ���ʱ��
        /// <summary>
        public  DateTime  H_CheckTime{ get; set; }

    }
}
