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

namespace Snake.Pages.Game
{
    public partial class GameOverPage : Page
    {
        private readonly GameMenu gameMenu;
        private readonly int score;
        private bool newRecord;

        public GameOverPage(GameMenu gameMenu, int score, bool newRecord)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
            this.score = score;
            this.newRecord = newRecord;
        }

        private void GameOverPage_Loaded(object sender, RoutedEventArgs e)
        {
            ScoredPoints_TextBlock.Text = score.ToString();
            if (newRecord) NewRecord_TextBlock.Visibility = Visibility.Visible;
            else NewRecord_TextBlock.Visibility = Visibility.Hidden;

            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
        }

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

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CountdownToStartGamePage(gameMenu: gameMenu));
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(gameMenu: gameMenu));
        }
        #endregion

        #region MOUSE ENTER/LEAVE BUTTONS
        private void Music_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (gameMenu.MusicOn) Music_Button.ToolTip = "Turn off the music";
            else Music_Button.ToolTip = "Turn on the music";
        }

        private void NewGame_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: NewGame_Button);
        }

        private void NewGame_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(buttonName: NewGame_Button);
        }

        private void Menu_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseEnterButton(buttonName: Menu_Button);
        }

        private void Menu_Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeaveButton(buttonName: Menu_Button);
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
    }
}
