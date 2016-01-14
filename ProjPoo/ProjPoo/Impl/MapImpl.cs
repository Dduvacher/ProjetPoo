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

        private int size;
        private List<Position> position;
        private Position selectedPos;

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
                return size;
            }

            set
            {
                size = value;
            }
        }

        public List<Tiles> Tiles
        {
            get
            {
                return tiles;
            }

            set
            {
                tiles = value;
            }
        }

        public List<Position> positions
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public Position SelectedPos
        {
            get { return selectedPos; }
            set { selectedPos = value; }
        }

        public List<Position> nextTo(Position p)
        {
            List<Position> l = new List<Position>();
            foreach (Position p2 in this.positions)
            {
                if (Math.Abs(p.PosX - p2.PosX) + Math.Abs(p.PosY - p2.PosY) == 1){
                    l.Add(p);
                }
            }

            return l;
        }



        public MapImpl(int size)
        {
            Size = size;
            tiles = new List<Tiles>();
            defAlgo(size);
            positions = new List<Position>();

            switch (size)
            {
                case 0:
                    for(int i = 0; i < 6; i++)
                    {
                        for(int j = 0; j < 6; j++)
                        {
                            positions.Add(FactoryPosition.INSTANCE.createPosition(j,i));
                        }
                    }
                    break;

                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            positions.Add(FactoryPosition.INSTANCE.createPosition(j, i));
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < 14; i++)
                    {
                        for (int j = 0; j < 14; j++)
                        {
                            positions.Add(FactoryPosition.INSTANCE.createPosition(j, i));
                        }
                    }
                    break;
            }
        }

        public Tiles getTile(Position pos)
        {
            return tiles[pos.PosX + 6 * pos.PosY];
        }


        public void defAlgo(int size)
        {
            switch (size)
            {
                case 0:
                    this.PhilAlgo = new Demo(this);
                    break;
                case 1:
                    this.PhilAlgo= new Small(this);
                    break;
                case 2:
                    this.PhilAlgo = new Standard(this);
                    break;
                default:
                    System.Console.WriteLine("Ce mode n'éxiste pas");
                    break;     
            }
        }

        public void fillMap()
        {
            int[] tabTiles = this.PhilAlgo.execute();
            foreach(int t in tabTiles)
            {
                switch(t)
                {
                    case 0:
                        this.tiles.Add(FlyweightTiles.INSTANCE.getPlain());
                        break;
                    case 1:
                        this.tiles.Add(FlyweightTiles.INSTANCE.getMountain());
                        break;
                    case 2:
                        this.tiles.Add(FlyweightTiles.INSTANCE.getForest());
                        break;
                    case 3:
                        this.tiles.Add(FlyweightTiles.INSTANCE.getWater());
                        break;
                }
            }
        }
    }
}