using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FaultyKeyboardCsharp
{
    public class Solution
    {

        public string FinalString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            int index = s.IndexOf('i');
            if (index == -1)
                return s;
            else
            {
                string res = string.Empty;
                while (index > -1)
                {

                    res = new string(s.Substring(0, index).Reverse().ToArray());
                    if (s.Length > index + 1)
                    {
                        res = res + s.Substring(index + 1);
                    }
                    s = res;
                    index = s.IndexOf('i');
                }
            }
            return s;
        }
    }
}
