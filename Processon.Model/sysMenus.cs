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
        /// �˵����
        /// <summary>
        public  int?  MID{ get; set; }

        /// <summary>
        /// �����˵����
        /// <summary>
        public  int  MParentID{ get; set; }

        /// <summary>
        /// �˵�����
        /// <summary>
        public  string  MName{ get; set; }

        /// <summary>
        /// �˵���ַ
        /// <summary>
        public  string  MUrl{ get; set; }

        /// <summary>
        /// ����
        /// <summary>
        public  string  MArea{ get; set; }

        /// <summary>
        /// ������
        /// <summary>
        public  string  MController{ get; set; }

        /// <summary>
        /// ����
        /// <summary>
        public  string  MAction{ get; set; }

        /// <summary>
        /// ������
        /// <summary>
        public  int  MSortid{ get; set; }

        /// <summary>
        /// 0:���� 1��ͣ��
        /// <summary>
        public  int  MStatus{ get; set; }

        /// <summary>
        /// �˵�ͼ��
        /// <summary>
        public  string  MPicname{ get; set; }

        /// <summary>
        /// �˵����� 0:���˵� 1һ���˵� 2:�����˵�
        /// <summary>
        public  int  MLevel{ get; set; }

        /// <summary>
        /// �����ֶ�
        /// <summary>
        public  string  MExp1{ get; set; }

        /// <summary>
        /// �����ֶ� 0:��ʾ����˵�Ҫ��ʾ  1������˵�����ʾ��Ȩ������Ҫ�ܿ�
        /// <summary>
        public  int  MExp2{ get; set; }

        /// <summary>
        /// �����û�
        /// <summary>
        public  int  MCreatorID{ get; set; }

        /// <summary>
        /// ����ʱ��
        /// <summary>
        public  DateTime  MCreateTime{ get; set; }

        /// <summary>
        /// �޸��û�
        /// <summary>
        public  int  MUpdateID{ get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// <summary>
        public  DateTime  MUpdateTime{ get; set; }

    }
}
