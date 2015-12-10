using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ModelEtudiant
{
    public enum TileType
    {
        Plain = 0,
        Moutain = 1,
        Forest = 2,
        Water = 3
    }

    public class Algo : IDisposable
    {
        bool disposed = false;
        IntPtr nativeAlgo;
     
        public int[] FillMap(int size)
        {
            TileType[] tiles = null;
            int nbTiles=0;
            int[] res = null;
            switch (size)
            {
                case 0:
                    nbTiles = 36;
                    tiles = new TileType[nbTiles];
                    res = new int[nbTiles];
                    break;
                case 1:
                    nbTiles = 100;
                    tiles = new TileType[nbTiles];
                    res = new int[nbTiles];
                    break;
                case 2:
                    nbTiles = 196;
                    tiles = new TileType[nbTiles];
                    res = new int[nbTiles];
                    break;
                default:
                    System.Console.WriteLine("CE MODE N4EXISTE PAS GROS BATARD.");
                    break;
            }
            
            Algo_fillMap(nativeAlgo, tiles, nbTiles);
            for(int i=0;i<res.Length;i++)
            {
                res[i] = (int)tiles[i];
            }
            return res;
        }

        public Algo()
        {
            nativeAlgo = Algo_new();
        }

        ~Algo()
        {
            Dispose(false);
            Algo_delete(nativeAlgo);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return; 
            if (disposing)
            {
                Algo_delete(nativeAlgo);
            }
            disposed = true;
        }


        [DllImport("libCPP.dll", CallingConvention= CallingConvention.Cdecl)]
        extern static void Algo_fillMap(IntPtr algo, TileType[] tiles, int nbTiles);

        [DllImport("libCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static IntPtr Algo_new();

        [DllImport("libCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static IntPtr Algo_delete(IntPtr algo);
    }
}
