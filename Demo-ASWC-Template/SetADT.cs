using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ASWC_Template
{
    public class SetADT:AbstractADT
    {
        protected override ICollection<string> CreateList()
        {
            return new HashSet<string>();
        }
    }
}
