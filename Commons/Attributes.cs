using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_Word_WPF_Project.Commons
{
    public class Attributes
    {
        public string WORD { get; set; }
        public string HINT { get; set; }
        public Attributes(int iD, string wORD, string hINT)
        {
            WORD = wORD;
            HINT = hINT;
        }

    }
}
