using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_Word_WPF_Project.Commons.v2
{
    public class AttributesBase : IAttributes
    {
        public string WORD { get; set; }
        public string HINT { get; set; }
        public string DIFFICULTY { get; set; }
    }
}
