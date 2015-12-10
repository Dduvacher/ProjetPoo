using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    //c'est une fabrique poids mouche pour les races
    public class FactoryRace
    {
        public static FactoryRace INSTANCE = new FactoryRace();
        private Dictionary<string , Race> mapRace;

        private FactoryRace()
        {
            mapRace = new Dictionary<string, Race>();
        }


        public Race getElf()
        {
            if (!mapRace.ContainsKey("elf"))
            {
                mapRace.Add("elf", new Elf());
            }
            return mapRace["elf"];
        }

        public Race getHuman()
        {
            if (!mapRace.ContainsKey("human"))
            {
                mapRace.Add("human", new Human());
            }
            return mapRace["human"];
        }

        public Race getOrc()
        {
            if(!mapRace.ContainsKey("orc"))
            {
                mapRace.Add("orc", new Orc());
            }
            return mapRace["orc"];
        }
    }
}