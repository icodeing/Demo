using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class OtherCheck
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  O_Id{ get; set; }

        /// <summary>
        /// �Ƿ�ͬ�⣬1:ͬ�⣬0:��ͬ��
        /// <summary>
        public  int  O_IsAgreed{ get; set; }

        /// <summary>
        /// ��ע˵��
        /// <summary>
        public  string  O_Node{ get; set; }

        /// <summary>
        /// ���ʱ��
        /// <summary>
        public  DateTime  O_CheckTime{ get; set; }

    }
}
