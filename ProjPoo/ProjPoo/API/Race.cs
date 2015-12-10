using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    //classe mère de toutes les races, défini tous les attributs que doivent avoir les classes.
    public interface Race
    {
        int Range { get; set; }
        int Life { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }

        //HashMap associant des points de victoire en fonction de la tuile ou le pion est présent.
        Dictionary<Tiles, int> VictPoint { get; set; }
    }
}