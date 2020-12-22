using Snake.Classes;
using Snake.Pages.Game;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace Snake.Pages
{
    public partial class CountdownToStartGamePage : Page
    {
        private readonly GameMenu gameMenu;
        private DispatcherTimer dispatcherTimer;
        private int counter = 1;

        public CountdownToStartGamePage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void CountdownToStartGamePage_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            dispatcherTimer.Tick += DispatcherTimerTick;
            dispatcherTimer.Start();
        }

        #region COUNTDOWN
        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            counter++;

            if (counter == 5)
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new GamePage(gameMenu: gameMenu));
            }
            else
            {
                switch (counter)
                {
                    case 2:
                        ChangeImage(path: "/Images/Game/CountdownToStartGame/2.png");
                        break;

                    case 3:
                        ChangeImage(path: "/Images/Game/CountdownToStartGame/1.png");
                        break;

                    case 4:
                        //CountdownToStartGame_Image.Height = 500;
                        CountdownToStartGame_Image.Width = 575;
                        ChangeImage(path: "/Images/Game/CountdownToStartGame/Start1.png");
                        break;

                    default:
                        break;
                }
            }
        }

        private void ChangeImage(string path)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@path, UriKind.Relative);
            bitmapImage.EndInit();

            CountdownToStartGame_Image.Source = bitmapImage;
        }
        #endregion
    }
}
