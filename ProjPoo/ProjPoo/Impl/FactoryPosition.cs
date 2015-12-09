using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class FactoryPosition
    {
        public static FactoryPosition INSTANCE = new FactoryPosition();
        public Position createPosition(int x , int y)
        {
            return new PositionImpl(x, y);
        }
    }
}