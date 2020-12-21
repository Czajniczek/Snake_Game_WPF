using MaterialDesignThemes.Wpf;
using Snake.Classes;
using Snake.Windows;
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

namespace Snake.Pages
{
    public partial class MenuPage : Page
    {
        readonly GameMenu gameMenu;

        public MenuPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void MenuPage_Loaded(object sender, RoutedEventArgs e)
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

        private void NewGame_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: NewGame_Button, path: "/Images/Menu/NewGame.png");
        }

        private void NewGame_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(NewGame_Button);
        }

        private void BestResults_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: BestResults_Button, path: "/Images/Menu/Trophy.png");
        }

        private void BestResults_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(BestResults_Button);
        }

        private void Settings_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: Settings_Button, path: "/Images/Menu/Settings.png");
        }

        private void Settings_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(Settings_Button);
        }

        private void Author_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: Author_Button, path: "/Images/Menu/Author.png");
        }

        private void Author_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(Author_Button);
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
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow { Owner = Window.GetWindow(this) };
            exitWindow.ShowDialog();
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BeforeStartPage(gameMenu: gameMenu));
        }

        private void BestResultsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BestResultsPage(gameMenu: gameMenu));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage(gameMenu: gameMenu));

            #region SETTINGS
            #region GAMEPLAY
            #region DIFFICULTY LEVEL
            //EASY
            //MEDIUM
            //HARD
            #endregion DIFFICULTY LEVEL
            #region OWN SETTING
            #region SNAKE SPEED
            //SLOW
            //NORMAL
            //FAST
            //VERY FAST
            #endregion SNAKE SPEED
            #region BONUS FRUIT
            //RARELY
            //NORMALLY
            //OFTEN
            //VERY OFTEN
            #endregion BONUS FRUIT
            #endregion OWN SETTINGS
            #endregion GAMEPLAY
            #region MUSIC
            //CHANGE
            //TURN ON/OFF
            #endregion MUSIC
            #endregion SETTINGS
        }

        private void AuthorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorPage(gameMenu: gameMenu));
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
        #endregion BUTTONS CLICKS
    }
}
