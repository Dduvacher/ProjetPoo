using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Input;
using ProjPoo;


namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String[] playerRace = new String[2];
        private GameBuilder game = new GameBuilder();
        private Pawn selectedUnit;

        public MainWindow()
        {
            InitializeComponent();

            raceJ1.ItemsSource = new List<string> { "Elf", "Human", "Orc" };
            raceJ2.ItemsSource = new List<string> { "Elf", "Human", "Orc" };
            gametype.ItemsSource = new List<string> { "Demo", "Small", "Standart" };
            gametype.SelectedIndex = 0;
            raceJ1.SelectedIndex = 0;
            raceJ2.SelectedIndex = 1;
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            playerRace[0] = (string)raceJ1.SelectedItem;
            playerRace[1] = (string)raceJ2.SelectedItem;

            if (playerRace[0] == playerRace[1])
            {
                SameRace.Visibility = System.Windows.Visibility.Visible;
                return;
            }
            else
            {
                string r1 = playerRace[0];
                switch (r1)
                {
                    case "Human":
                        game.race1 = FactoryRace.INSTANCE.getHuman();
                        break;
                    case "Orc":
                        game.race1 = FactoryRace.INSTANCE.getOrc();
                        break;
                    case "Elf":
                        game.race1 = FactoryRace.INSTANCE.getElf();
                        break;
                }
                string r2 = playerRace[1];
                switch (r2)
                {
                    case "Human":
                        game.race2 = FactoryRace.INSTANCE.getHuman();
                        break;
                    case "Orc":
                        game.race2 = FactoryRace.INSTANCE.getOrc();
                        break;
                    case "Elf":
                        game.race2 = FactoryRace.INSTANCE.getElf();
                        break;
                }
                game.pseudo1 = J1.Text;
                game.pseudo2 = J2.Text;
                string s = (string)gametype.SelectedItem;
                switch (s)
                {
                    case "Demo":
                        game.addsize(0);
                        break;
                    case "Small":
                        game.addsize(1);
                        break;
                    case "Standart":
                        game.addsize(2);
                        break;
                }
                game.build();

                Map map = game.getgame().Mape;
                double size = Math.Sqrt(map.Tiles.Count);

                for (int i = 0; i < size; i++)
                {
                    Grille.RowDefinitions.Add(new RowDefinition()
                    {
                        Height = new GridLength(Math.Floor((double)600 / size), GridUnitType.Pixel)
                    });
                    Grille.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(Math.Floor((double)600 / size), GridUnitType.Pixel)
                    });
                }
                for (int i = 0; i < size*size; i++)
                {
                        createTile(i);
                   
                }
                Game.Visibility = System.Windows.Visibility.Visible;
                MainMenu.Visibility = System.Windows.Visibility.Hidden;
            }
        }

            public void createTile(int i)
        {
            Map m = game.getgame().Mape;
            Tiles t = m.Tiles[i];
            double largeur = Math.Sqrt((double)game.getgame().Mape.Tiles.Count);
            Rectangle r = new Rectangle();
            r.Fill = Image.INSTANCE.brushTile(t);
            Grille.Children.Add(r);
            Grid.SetRow(r, i/(int)largeur);
            Grid.SetColumn(r, i%(int)largeur);


            if(game.getgame().Mape.positions[i].Pawns.Count != 0)
            {
                r = new Rectangle();
                r.Fill = Image.INSTANCE.brushRace(game.getgame().Mape.positions[i].Pawns[0].race);
                Grille.Children.Add(r);
                Grid.SetRow(r, i / (int)largeur);
                Grid.SetColumn(r, i % (int)largeur);
            }

            /*foreach (Position p in game.getgame().Mape.nextTo(game.getgame().Mape.SelectedPos))
            {
                Rectangle r2 = new Rectangle();
                r2.Fill = Image.INSTANCE.brushMove();
                Grille.Children.Add(r2);
                Grid.SetRow(r2, i / (int)largeur);
                Grid.SetColumn(r2, i % (int)largeur);

                break;
            }

            r.MouseLeftButtonDown += new MouseButtonEventHandler(LeftClick);
            r.MouseRightButtonDown += new MouseButtonEventHandler(RightClick);*/
        }
        

       /* public void LeftClick(object sender, RoutedEventArgs e)
        {
            Position p = game.getgame().Mape.SelectedPos;

            List<Position> p1 = new List<Position>();

            foreach (Position pa in game.getgame().Mape.nextTo(p))
            {
                p1.Add(pa);
            }

            int i = Grid.GetRow((Rectangle)sender);
            int j = Grid.GetColumn((Rectangle)sender);
            game.getgame().Mape.SelectedPos = new PositionImpl(i, j);
            createTile(game.getgame().Mape.positions.IndexOf(game.getgame().Mape.SelectedPos));
            if (p.PosX)
        }*/

        private void NextTurn(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
