using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Type
    {
        int tiles { get; set; }
        int turns { get; set; }
        int units { get; set; }
        int players { get; set; }
    }
}