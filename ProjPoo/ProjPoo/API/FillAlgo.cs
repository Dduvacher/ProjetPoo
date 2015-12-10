using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjPoo
{
    //classe nécessaire pour la strategy, pour le choix des stratégies. C'est la classe Mère des différentes tailles de map.
    public interface FillAlgo
    {
        int Units { get; set; }

        int Turns { get; set; }

        Map Map { get; set; }

        ModelEtudiant.Algo algo {get;set;} 

        int[] execute();
    }
}