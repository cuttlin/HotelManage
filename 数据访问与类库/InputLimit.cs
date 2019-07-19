using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 数据访问与类库
{
    /// <summary>
    /// 用于限制与判断用户输入的数据
    /// </summary>
    class InputLimit
    {
        /// <summary>
        /// 判断是否是int
        /// </summary>
        /// <param name="temp">要判断的字符</param>
        /// <param name="num">返回的数字</param>
        /// <returns>是否是int</returns>
        public static bool IsInt(string temp,out int num)
        {
            num = 0;
            return false;  
        }
    }
}
