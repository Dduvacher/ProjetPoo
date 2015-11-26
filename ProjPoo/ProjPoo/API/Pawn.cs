using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public interface Pawn
    {
        Player player { get; set; }
        Race race { get; set; }
        Position position { get; set; }
        int MovePoint { get; set; }

        void attack_action();
        void move_action();
    }
}