using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.Model
{
    public class SysMenus
    {
        /// <summary>
        /// 菜单编号
        /// <summary>
        public  int?  MID{ get; set; }

        /// <summary>
        /// 父级菜单编号
        /// <summary>
        public  int  MParentID{ get; set; }

        /// <summary>
        /// 菜单名称
        /// <summary>
        public  string  MName{ get; set; }

        /// <summary>
        /// 菜单地址
        /// <summary>
        public  string  MUrl{ get; set; }

        /// <summary>
        /// 区域
        /// <summary>
        public  string  MArea{ get; set; }

        /// <summary>
        /// 控制器
        /// <summary>
        public  string  MController{ get; set; }

        /// <summary>
        /// 方法
        /// <summary>
        public  string  MAction{ get; set; }

        /// <summary>
        /// 排序编号
        /// <summary>
        public  int  MSortid{ get; set; }

        /// <summary>
        /// 0:正常 1：停用
        /// <summary>
        public  int  MStatus{ get; set; }

        /// <summary>
        /// 菜单图标
        /// <summary>
        public  string  MPicname{ get; set; }

        /// <summary>
        /// 菜单级别 0:根菜单 1一级菜单 2:二级菜单
        /// <summary>
        public  int  MLevel{ get; set; }

        /// <summary>
        /// 备用字段
        /// <summary>
        public  string  MExp1{ get; set; }

        /// <summary>
        /// 备用字段 0:表示在左菜单要显示  1：在左菜单不显示，权限是需要管控
        /// <summary>
        public  int  MExp2{ get; set; }

        /// <summary>
        /// 创建用户
        /// <summary>
        public  int  MCreatorID{ get; set; }

        /// <summary>
        /// 创建时间
        /// <summary>
        public  DateTime  MCreateTime{ get; set; }

        /// <summary>
        /// 修改用户
        /// <summary>
        public  int  MUpdateID{ get; set; }

        /// <summary>
        /// 修改时间
        /// <summary>
        public  DateTime  MUpdateTime{ get; set; }

    }
}
