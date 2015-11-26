using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Position
    {
        int PosX { get; set; }
        int PosY { get; set; }

        bool nextTo();
    }
}