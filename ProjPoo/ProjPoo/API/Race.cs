using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Race
    {
        int Range { get; set; }
        int Life { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        Dictionary<Tiles, int> VictPoint { get; set; }
    }
}