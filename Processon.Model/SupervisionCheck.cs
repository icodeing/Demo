using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class SupervisionCheck
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  S_Id{ get; set; }

        /// <summary>
        /// �Ƿ�ͬ�⣬1:ͬ�⣬0:��ͬ��
        /// <summary>
        public  int  S_IsAgreed{ get; set; }

        /// <summary>
        /// ��ע˵��
        /// <summary>
        public  string  S_Node{ get; set; }

        /// <summary>
        /// ���ʱ��
        /// <summary>
        public  DateTime  S_CheckTime{ get; set; }

    }
}
