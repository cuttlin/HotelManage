using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace 数据访问与类库
{
    /// <summary>
    /// 进行MD5加密的功能类
    /// </summary>
    public class MD5Helper
    {
        private static MD5 md5 = MD5.Create();

        /// <summary>
        /// 将传入的字符串进行MD5加密
        /// </summary>
        /// <param name="str">待加密的字符串</param>
        /// <returns>加密后的结果</returns>
        public static string ToMD5(string str)
        {
            byte[] buf = Encoding.Default.GetBytes(str);
            byte[] newBuf = md5.ComputeHash(buf);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newBuf.Length; i++)
            {
                sb.Append(newBuf[i].ToString("x2"));
            }
            string md5Pwd = sb.ToString();
            return md5Pwd;
        }
    }
}
