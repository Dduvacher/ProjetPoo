using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class FactoryMap
    {
        public static FactoryMap INSTANCE = new FactoryMap();
        public Map createMap(int size)
        {
            return new MapImpl(size);
        }
    }
}