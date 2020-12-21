using MaterialDesignThemes.Wpf;
using Snake.Classes;
using Snake.Windows;
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

namespace Snake.Pages
{
    public partial class DifficultyLevelPage : Page
    {
        private readonly GameMenu gameMenu;

        public DifficultyLevelPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void DifficultyLevelPage_Loaded(object sender, RoutedEventArgs e)
        {
            SetLevel();

            gameMenu.OwnSettings = false;
            gameMenu.BonusFruit = 1;
            gameMenu.SnakeSpeed = 1;

            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
        }

        private void SetLevel()
        {
            switch (gameMenu.Level)
            {
                case 1:
                    Level_TextBlock.Text = "EASY";
                    //Level_TextBlock.Foreground = Brushes.Green;
                    Level_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                    Down_Button.IsEnabled = false;
                    SetImage(path: "/Images/Settings/DifficultyLevel/EasySnake1.png");
                    break;

                case 2:
                    Level_TextBlock.Text = "MEDIUM";
                    Up_Button.IsEnabled = true;
                    Down_Button.IsEnabled = true;
                    Level_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(200, 190, 30));
                    SetImage(path: "/Images/Settings/DifficultyLevel/MediumSnake.png");
                    break;

                case 3:
                    Level_TextBlock.Text = "HARD";
                    Up_Button.IsEnabled = false;
                    Level_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(153, 0, 0));
                    SetImage(path: "/Images/Settings/DifficultyLevel/HardSnake.png");
                    break;

                default:
                    break;
            }
        }

        private void SetImage(string path)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@path, UriKind.Relative);
            bitmapImage.EndInit();
            Left_Image.Source = bitmapImage;
            Right_Image.Source = bitmapImage;
        }

        #region MOUSE ENTER/LEAVE BUTTONS
        private void Music_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (gameMenu.MusicOn) Music_Button.ToolTip = "Turn off the music";
            else Music_Button.ToolTip = "Turn on the music";
        }
        #endregion

        #region BUTTONS CLICKS
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage(gameMenu: gameMenu));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow { Owner = Window.GetWindow(this) };
            exitWindow.ShowDialog();
        }

        private void MusicButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameMenu.MusicOn)
            {
                Music_Icon.Kind = PackIconKind.MusicOff;
                gameMenu.StopMusic();
                gameMenu.MusicOn = false;
            }
            else
            {
                Music_Icon.Kind = PackIconKind.Music;
                gameMenu.PlayMusic();
                gameMenu.MusicOn = true;
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.Level++;
            SetLevel();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.Level--;
            SetLevel();
        }
        #endregion
    }
}
