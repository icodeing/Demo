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
        /// 与Category表关联的类别ID
        /// <summary>
        public Guid CId { get; set; }

        /// <summary>
        /// 大类别
        /// <summary>
        public Guid BigType { get; set; }

        /// <summary>
        /// 小类别
        /// <summary>
        public Guid SamllType { get; set; }

        /// <summary>
        /// 品牌
        /// <summary>
        public  string  Brand{ get; set; }

        /// <summary>
        /// 数量
        /// <summary>
        public  int  Number{ get; set; }

        /// <summary>
        /// 单位
        /// <summary>
        public  Guid UnitId { get; set; }

        /// <summary>
        /// 份
        /// <summary>
        public  int  Singleton{ get; set; }

        /// <summary>
        /// 单价
        /// <summary>
        public  decimal  UnitPrice{ get; set; }

        /// <summary>
        /// 总金额
        /// <summary>
        public  decimal  CountPrice{ get; set; }

        /// <summary>
        /// 施工负责人ID
        /// <summary>
        public  Guid  HId{ get; set; }

        /// <summary>
        /// 施工监理ID
        /// <summary>
        public  Guid  SId{ get; set; }

        /// <summary>
        /// 资金管理ID
        /// <summary>
        public  Guid  MId{ get; set; }

        /// <summary>
        /// 财务ID
        /// <summary>
        public  Guid  FId{ get; set; }

        /// <summary>
        /// 出纳ID
        /// <summary>
        public  Guid CashierCheckId { get; set; }

        /// <summary>
        /// 其他
        /// <summary>
        public  Guid  OId{ get; set; }

        public DateTime CreateTime { get; set; }

    }
}
