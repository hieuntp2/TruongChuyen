using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransactionCode
{
    public static class MyDecodeUnicode
    {
        public static string DecodeFromUtf8(this string utf8String)
        {
            StringBuilder retu = new StringBuilder();
       
            for(int i = 0; i < utf8String.Length; i++)
            {
                if(utf8String[i] != '\0')
                {
                    retu.Append(utf8String[i]);
                }
                else
                {
                    break;
                }
            }
            return retu.ToString();           
        }
    }
}
