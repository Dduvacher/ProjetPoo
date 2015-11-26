using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjPoo
{
    public class MapImpl : Map
    {
        private FillAlgo fillAlgo;
        private List<Tiles> tiles;

        public FillAlgo PhilAlgo
        {
            get
            {
                return fillAlgo;
            }

            set
            {
                fillAlgo = value;
            }
        }

        public int Size
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Tiles> Tiles
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public MapImpl(int size)
        {
            Size = size;
            tiles = new List<Tiles>();
            defAlgo(size);
        }

        public void defAlgo(int size)
        {
            switch (size)
            {
                case 0:
                    this.PhilAlgo = new Demo();
                    break;
                case 1:
                    this.PhilAlgo= new Small();
                    break;
                case 2:
                    this.PhilAlgo = new Standard();
                    break;
                default:
                    System.Console.WriteLine("CE MODE N4EXISTE PAS GROS BATARD.");
                    break;     
            }
        }

        public void fillMap()
        {
            throw new NotImplementedException();
        }
    }
}