using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Processon.Common
{
    public static class JsonHelper
    {

        public static string GetJsonResult(string json,int count)
        {
            string result = "{\"Rows\":"+json+ ",\"Total\":"+count+"}";
            return result;
        }

        public static string Success()
        {
            return "{\"Status\":\"1\",\"msg\":\"成功\"}";
        }

        public static string Failure()
        {
            return "{\"Status\":\"-1\",\"msg\":\"失败\"}";
        }
    }
}
