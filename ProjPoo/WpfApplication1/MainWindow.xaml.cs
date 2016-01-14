using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using ProjPoo;


namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String[] playerRace = new String[2];
        private GameBuilder game = null;
        private int selectedUnit = -1;


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
                string r2 = playerRace[0];
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

                Map map = game.getMap();
                int size = map.Tiles.Count;

                for (int i = 0; i < size; i++)
                {
                    Grille.RowDefinitions.Add(new RowDefinition()
                    {
                        Height = new GridLength(Math.Floor((double)Grille.Height / size), GridUnitType.Pixel)
                    });
                    Grille.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(Math.Floor((double)Grille.Width / size), GridUnitType.Pixel)
                    });
                }
                for (int i = 0; i < size; i++)
                {
                        createTile(i);
                   
                }
            }
        }

            public void createTile(int i)
        {
            Map m = game.getMap();
            Tiles t = m.Tiles[i];

            Rectangle r = new Rectangle();
            r.Fill = Image.INSTANCE.brushTile(t);
            Grille.Children.Add(r);
            Grid.SetRow(r, i);
            Grid.SetColumn(r, i);


        }
        



        private void NextTurn(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
