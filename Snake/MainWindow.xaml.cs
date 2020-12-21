using Snake.Classes;
using Snake.Enums;
using Snake.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snake
{
    public partial class MainWindow : Window
    {
        readonly GameMenu gameMenu = new GameMenu(Level: LevelEnum.Easy, OwnSettings: false,
            SnakeSpeed: SnakeSpeedEnum.Slow, BonusFruit: BonusFruitFrequencyEnum.Rarely,
            MusicPath: "Music/Snake_Song.wav", MusicOn: true);

        public MainWindow()
        {
            InitializeComponent();

            gameMenu.PlayMusic();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new MenuPage(gameMenu: gameMenu));
        }

        private void Content_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
