﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_Word_WPF_Project.Commons.v2
{
    public interface IAttributes
    {
        string WORD { get; set; }
        string HINT { get; set; }
        string DIFFICULTY { get; set; }
    }
}
