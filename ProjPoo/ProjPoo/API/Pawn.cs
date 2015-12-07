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
        double MovePoint { get; set; }

        Map map { get; set; }

        void attack_action();
        void move_action(Position pos);
    }
}