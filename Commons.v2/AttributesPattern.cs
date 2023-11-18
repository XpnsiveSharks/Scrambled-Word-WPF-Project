using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_Word_WPF_Project.Commons.v2
{
    public class AttributesPattern<K,T> where T: class, K, new()
    {
        public static K GetIntance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}
