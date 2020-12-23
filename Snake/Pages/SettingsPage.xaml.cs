using MaterialDesignThemes.Wpf;
using Snake.Classes;
using Snake.Pages.Settings;
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
    public partial class SettingsPage : Page
    {
        private readonly GameMenu gameMenu;

        public SettingsPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void SettingsPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
        }

        #region MOUSE ENTER/LEAVE BUTTONS
        private void Music_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (gameMenu.MusicOn) Music_Button.ToolTip = "Turn off the music";
            else Music_Button.ToolTip = "Turn on the music";
        }

        private void DifficultyLevel_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: DifficultyLevel_Button, path: "/Images/Settings/DifficultyLevel.png");
        }

        private void DifficultyLevel_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(DifficultyLevel_Button);
        }

        private void OwnSettings_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: OwnSettings_Button, path: "/Images/Settings/CustomizedSettings.png");
        }

        private void OwnSettings_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(OwnSettings_Button);
        }

        private void MusicSettings_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: MusicSettings_Button, path: "/Images/Settings/Music.png");
        }

        private void MusicSettings_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(MusicSettings_Button);
        }

        private void MouseEnterButton(Button buttonName, string path)
        {
            buttonName.Height = 37;
            buttonName.Width = 225;

            buttonName.Background = new SolidColorBrush(Color.FromRgb(30, 130, 35));
            buttonName.BorderBrush = new SolidColorBrush(Color.FromRgb(30, 130, 35));
            buttonName.Foreground = Brushes.White;

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@path, UriKind.Relative);
            bitmapImage.EndInit();
            Left_Image.Source = bitmapImage;
            Right_Image.Source = bitmapImage;

            ShowImages();
        }

        private void MouseLeaveButton(Button buttonName)
        {
            buttonName.Height = 32;
            buttonName.Width = 210;

            buttonName.Background = new SolidColorBrush(Color.FromRgb(76, 175, 80));
            buttonName.BorderBrush = new SolidColorBrush(Color.FromRgb(76, 175, 80));
            buttonName.Foreground = Brushes.Black;

            HideImages();
        }

        private void ShowImages()
        {
            Left_Image.Visibility = Visibility.Visible;
            Right_Image.Visibility = Visibility.Visible;
        }

        private void HideImages()
        {
            Left_Image.Visibility = Visibility.Hidden;
            Right_Image.Visibility = Visibility.Hidden;
        }
        #endregion MOUSE ENTER/LEAVE BUTTONS

        #region BUTTONS CLICKS
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(gameMenu: gameMenu));
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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow { Owner = Window.GetWindow(this) };
            exitWindow.ShowDialog();
        }

        private void DifficultyLevelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DifficultyLevelPage(gameMenu: gameMenu));
        }

        private void OwnSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizedSettingsPage(gameMenu: gameMenu));
        }

        private void MusicSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MusicPage(gameMenu: gameMenu));
        }
        #endregion BUTTONS CLICKS
    }
}
