using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class Examination
    {
        /// <summary>
        /// 
        /// <summary>
        public  Guid  EId{ get; set; }

        /// <summary>
        /// ��Category����������ID
        /// <summary>
        public Guid CId { get; set; }

        /// <summary>
        /// �����
        /// <summary>
        public Guid BigType { get; set; }

        /// <summary>
        /// С���
        /// <summary>
        public Guid SamllType { get; set; }

        /// <summary>
        /// Ʒ��
        /// <summary>
        public  string  Brand{ get; set; }

        /// <summary>
        /// ����
        /// <summary>
        public  int  Number{ get; set; }

        /// <summary>
        /// ��λ
        /// <summary>
        public  Guid UnitId { get; set; }

        /// <summary>
        /// ��
        /// <summary>
        public  int  Singleton{ get; set; }

        /// <summary>
        /// ����
        /// <summary>
        public  decimal  UnitPrice{ get; set; }

        /// <summary>
        /// �ܽ��
        /// <summary>
        public  decimal  CountPrice{ get; set; }

        /// <summary>
        /// ʩ��������ID
        /// <summary>
        public  Guid  HId{ get; set; }

        /// <summary>
        /// ʩ������ID
        /// <summary>
        public  Guid  SId{ get; set; }

        /// <summary>
        /// �ʽ����ID
        /// <summary>
        public  Guid  MId{ get; set; }

        /// <summary>
        /// ����ID
        /// <summary>
        public  Guid  FId{ get; set; }

        /// <summary>
        /// ����ID
        /// <summary>
        public  Guid CashierCheckId { get; set; }

        /// <summary>
        /// ����
        /// <summary>
        public  Guid  OId{ get; set; }

        public DateTime CreateTime { get; set; }

    }
}
