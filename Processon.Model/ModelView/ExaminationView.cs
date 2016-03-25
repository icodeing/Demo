using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model.ModelView
{
    public partial class ExaminationView: Examination
    {
        /// <summary>
        /// 
        /// <summary>
        public Guid C_Id { get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public int C_IsAgreed { get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public string C_Node { get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public DateTime C_CheckTime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public Guid F_Id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public int F_IsAgreed { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string F_Node { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public DateTime F_CheckTime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public Guid H_Id { get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public int H_IsAgreed { get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public string H_Node { get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public DateTime H_CheckTime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public Guid M_Id { get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public int M_IsAgreed { get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public string M_Node { get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public DateTime M_CheckTime { get; set; }


        /// <summary>
        /// 
        /// <summary>
        public Guid S_Id { get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public int S_IsAgreed { get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public string S_Node { get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public DateTime S_CheckTime { get; set; }


        /// <summary>
        /// 
        /// <summary>
        public Guid O_Id { get; set; }

        /// <summary>
        /// 是否同意，1:同意，0:不同意
        /// <summary>
        public int O_IsAgreed { get; set; }

        /// <summary>
        /// 备注说明
        /// <summary>
        public string O_Node { get; set; }

        /// <summary>
        /// 审核时间
        /// <summary>
        public DateTime O_CheckTime { get; set; }



        /// <summary>
        /// 
        /// <summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string TypeName { get; set; }



        #region BigType -大类别
        /// <summary>
        /// 
        /// <summary>
        public Guid BigID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string BigTypeName { get; set; }

  


        #endregion



        #region SmallType  --小类别
        /// <summary>
        /// 
        /// <summary>
        public Guid SmallTypeId { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string SmallTypeName { get; set; }

        #endregion

        #region Unit  --单位类型
        public Guid UnitId { get; set; }

        /// <summary>
        /// 单位类型，如:个，只
        /// <summary>
        public string UnitName { get; set; } 
        #endregion

    }
}
