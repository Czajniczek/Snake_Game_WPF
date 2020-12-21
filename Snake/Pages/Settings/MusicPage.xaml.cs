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
    public partial class MusicPage : Page
    {
        private readonly GameMenu gameMenu;

        public MusicPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void MusicPage_Loaded(object sender, RoutedEventArgs e)
        {
            SetMusic();

            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
        }

        private void SetMusic()
        {
            if (gameMenu.MusicOn)
            {
                switch (gameMenu.MusicPath)
                {
                    case "Music/Snake_Song.wav":
                        ShowHideGifs(imageName1: LeftSnakeSong_Gif, imageName2: RightSnakeSong_Gif, buttonName: SnakeSong_Button);
                        break;

                    case "Music/Benny_Hill_Yakety_Sax.wav":
                        ShowHideGifs(imageName1: LeftBennyHillSong_Gif, imageName2: RightBennyHillSong_Gif, buttonName: BennySong_Button);
                        break;

                    default:
                        break;
                }
            }
        }

        private void ShowHideGifs(Image imageName1, Image imageName2, Button buttonName)
        {
            imageName1.Visibility = Visibility.Visible;
            imageName2.Visibility = Visibility.Visible;
            buttonName.IsEnabled = false;
        }

        #region MOUSE ENTER/LEAVE BUTTONS
        private void Music_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (gameMenu.MusicOn) Music_Button.ToolTip = "Turn off the music";
            else Music_Button.ToolTip = "Turn on the music";
        }

        private void SnakeSong_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: SnakeSong_Button);
        }

        private void SnakeSong_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(buttonName: SnakeSong_Button);
        }

        private void BennySong_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: BennySong_Button);
        }

        private void BennySong_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(buttonName: BennySong_Button);
        }

        private void MouseEnterButton(Button buttonName)
        {
            buttonName.Height = 37;
            buttonName.Width = 225;

            buttonName.Background = new SolidColorBrush(Color.FromRgb(30, 130, 35));
            buttonName.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 130, 35));
            buttonName.Foreground = Brushes.White;
        }

        private void MouseLeaveButton(Button buttonName)
        {
            buttonName.Height = 32;
            buttonName.Width = 210;

            buttonName.Background = new SolidColorBrush(Color.FromRgb(76, 175, 80));
            buttonName.BorderBrush = new SolidColorBrush(Color.FromRgb(76, 175, 80));
            buttonName.Foreground = Brushes.Black;
        }
        #endregion

        #region BUTTONS CLICKS
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage(gameMenu: gameMenu));
        }

        private void MusicButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameMenu.MusicOn) TurnOffTheMusic();
            else TurnOnTheMusic();
        }

        private void TurnOffTheMusic()
        {
            Music_Icon.Kind = PackIconKind.MusicOff;
            gameMenu.StopMusic();
            SnakeSong_Button.IsEnabled = true;
            BennySong_Button.IsEnabled = true;
            LeftSnakeSong_Gif.Visibility = Visibility.Hidden;
            RightSnakeSong_Gif.Visibility = Visibility.Hidden;
            LeftBennyHillSong_Gif.Visibility = Visibility.Hidden;
            RightBennyHillSong_Gif.Visibility = Visibility.Hidden;
        }

        private void TurnOnTheMusic()
        {
            Music_Icon.Kind = PackIconKind.Music;
            gameMenu.PlayMusic();
            SetMusic();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow { Owner = Window.GetWindow(this) };
            exitWindow.ShowDialog();
        }

        private void SnakeSongButton_Click(object sender, RoutedEventArgs e)
        {
            List<Image> hideGifsList = new List<Image>
            {
                LeftBennyHillSong_Gif,
                RightBennyHillSong_Gif
            };

            List<Image> showGifsList = new List<Image>
            {
                LeftSnakeSong_Gif,
                RightSnakeSong_Gif
            };

            ChangeButtonStyleAccordingToMusic(hideGifsList: hideGifsList, showGifsList: showGifsList, enabledButton: BennySong_Button, disabledButton: SnakeSong_Button);
            gameMenu.MusicPath = "Music/Snake_Song.wav";
            gameMenu.PlayMusic();
        }

        private void BennySongButton_Click(object sender, RoutedEventArgs e)
        {
            List<Image> hideGifsList = new List<Image>
            {
                LeftSnakeSong_Gif,
                RightSnakeSong_Gif
            };

            List<Image> showGifsList = new List<Image>
            {
                LeftBennyHillSong_Gif,
                RightBennyHillSong_Gif
            };

            ChangeButtonStyleAccordingToMusic(hideGifsList: hideGifsList, showGifsList: showGifsList, enabledButton: SnakeSong_Button, disabledButton: BennySong_Button);
            gameMenu.MusicPath = "Music/Benny_Hill_Yakety_Sax.wav";
            gameMenu.PlayMusic();
        }

        private void ChangeButtonStyleAccordingToMusic(List<Image> hideGifsList, List<Image> showGifsList, Button enabledButton, Button disabledButton)
        {
            foreach (var gif in hideGifsList) gif.Visibility = Visibility.Hidden;

            foreach (var gif in showGifsList) gif.Visibility = Visibility.Visible;

            enabledButton.IsEnabled = true;
            disabledButton.IsEnabled = false;
            gameMenu.MusicOn = true;
            Music_Icon.Kind = PackIconKind.Music;
        }
        #endregion
    }
}
