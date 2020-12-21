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

namespace Snake.Pages.Settings
{
    public partial class CustomizedSettingsPage : Page
    {
        private readonly GameMenu gameMenu;

        public CustomizedSettingsPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void CustomizedSettingsPage_Loaded(object sender, RoutedEventArgs e)
        {
            SetBonusFruitFrequency();
            SetSnakeSpeed();

            gameMenu.OwnSettings = true;
            gameMenu.Level = 1;

            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
        }

        private void SetBonusFruitFrequency()
        {
            switch (gameMenu.BonusFruit)
            {
                case 1:
                    BonusFruit_TextBlock.Text = "RARELY";
                    //Level_TextBlock.Foreground = Brushes.Green;
                    LeftBonusFruit_Button.IsEnabled = false;
                    SetImage(imageName1: LeftBonusFruit_Image, imageName2: RightBonusFruit_Image, path: "/Images/Settings/CustomizedSettings/BonusFruit/Rarely.png");
                    break;

                case 2:
                    BonusFruit_TextBlock.Text = "NORMALLY";
                    LeftBonusFruit_Button.IsEnabled = true;
                    RightBonusFruit_Button.IsEnabled = true;
                    SetImage(imageName1: LeftBonusFruit_Image, imageName2: RightBonusFruit_Image, path: "/Images/Settings/CustomizedSettings/BonusFruit/Normally.png");
                    break;

                case 3:
                    BonusFruit_TextBlock.Text = "OFTEN";
                    RightBonusFruit_Button.IsEnabled = false;
                    SetImage(imageName1: LeftBonusFruit_Image, imageName2: RightBonusFruit_Image, path: "/Images/Settings/CustomizedSettings/BonusFruit/Often.png");
                    break;

                default:
                    break;
            }
        }

        private void SetSnakeSpeed()
        {
            switch (gameMenu.SnakeSpeed)
            {
                case 1:
                    DifficultyLevel_TextBlock.Text = "SLOW";
                    //Level_TextBlock.Foreground = Brushes.Green;
                    DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                    LeftDifficultyLevel_Button.IsEnabled = false;
                    SetImage(imageName1: LeftDifficultyLevel_Image, imageName2: RightDifficultyLevel_Image, path: "/Images/Settings/CustomizedSettings/SnakeSpeed/Slow.png");
                    break;

                case 2:
                    DifficultyLevel_TextBlock.Text = "NORMALLY";
                    RightDifficultyLevel_Button.IsEnabled = true;
                    LeftDifficultyLevel_Button.IsEnabled = true;
                    DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(200, 190, 30));
                    SetImage(imageName1: LeftDifficultyLevel_Image, imageName2: RightDifficultyLevel_Image, path: "/Images/Settings/CustomizedSettings/SnakeSpeed/Normal.png");
                    break;

                case 3:
                    DifficultyLevel_TextBlock.Text = "FAST";
                    RightDifficultyLevel_Button.IsEnabled = false;
                    DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(153, 0, 0));
                    SetImage(imageName1: LeftDifficultyLevel_Image, imageName2: RightDifficultyLevel_Image, path: "/Images/Settings/CustomizedSettings/SnakeSpeed/Fast.png");
                    break;

                default:
                    break;
            }
        }

        private void SetImage(Image imageName1, Image imageName2, string path)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@path, UriKind.Relative);
            bitmapImage.EndInit();
            imageName1.Source = bitmapImage;
            imageName2.Source = bitmapImage;
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

        private void LeftBonusFruitButton_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.BonusFruit--;
            SetBonusFruitFrequency();
        }

        private void RightBonusFruitButton_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.BonusFruit++;
            SetBonusFruitFrequency();
        }

        private void LeftDifficultyLevel_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.SnakeSpeed--;
            SetSnakeSpeed();
        }

        private void RightDifficultyLevel_Click(object sender, RoutedEventArgs e)
        {
            gameMenu.SnakeSpeed++;
            SetSnakeSpeed();
        }
        #endregion
    }
}
