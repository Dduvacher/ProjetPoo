using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    public class FactoryRace
    {
        private static FactoryRace INSTANCE = new FactoryRace();
        private Dictionary<string , Race> mapRace;

        private FactoryRace()
        {
            mapRace = new Dictionary<string, Race>();
        }


        public Race getElf()
        {
            Race r = mapRace["elf"];

            if(r==null)
            {
                r = new Elf();
                mapRace.Add("elf", r);
            }
            return r;
        }

        public Race getHuman()
        {
            Race r = mapRace["human"];

            if (r == null)
            {
                r = new Human();
                mapRace.Add("human", r);
            }
            return r;
        }

        public Race getOrc()
        {
            Race r = mapRace["orc"];

            if (r == null)
            {
                r = new Orc();
                mapRace.Add("orc", r);
            }
            return r;
        }
    }
}