using MaterialDesignThemes.Wpf;
using Snake.Classes;
using Snake.Windows;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class BestResultsPage : Page
    {
        private readonly GameMenu gameMenu;

        public BestResultsPage(GameMenu gameMenu)
        {
            InitializeComponent();

            this.gameMenu = gameMenu;
        }

        private void BestResultsPage_Loaded(object sender, RoutedEventArgs e)
        {
            ShowResults(GetResults());

            if (!gameMenu.MusicOn) Music_Icon.Kind = PackIconKind.MusicOff;
            else Music_Icon.Kind = PackIconKind.Music;
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
        #endregion BUTTONS CLICKS

        #region RESULTS
        private List<GameResult> GetResults()
        {
            List<GameResult> resultsList = new List<GameResult>();

            StreamReader streamReader = new StreamReader("Results.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                string[] row = line.Split(' ');
                //resultsList.Add(new GameResult(ImagePath: "/Images/BestResults/Placeholder.png", Place: "", Score: row[0], Nickname: row[1], DifficultyLevel: row[2], Date: row[3]));
                resultsList.Add(new GameResult(ImagePath: null, Place: "", Score: row[0], Nickname: row[1], DifficultyLevel: row[2], Date: row[3]));
            }
            streamReader.Close();

            //resultsList.Sort(delegate (GameResult x, GameResult y) { return y.Score.CompareTo(x.Score); });
            //resultsList.Sort((GameResult x, GameResult y) => { return y.Score.CompareTo(x.Score); });
            resultsList.Sort((GameResult x, GameResult y) => y.Score.CompareTo(x.Score));

            //resultsList.Reverse();

            //BEST 10 SCORES
            //for (int i = 7; i < resultsList.Count; i++) resultsList.RemoveAt(i);
            resultsList = resultsList.Take(10).ToList();

            int counter = 1;

            foreach (GameResult person in resultsList)
            {
                if (counter < 10) person.Place = "0" + counter.ToString();
                else person.Place = counter.ToString();
                counter++;
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            resultsList[i].ImagePath = "/Images/BestResults/1stPlace.png";
            //            break;

            //        case 1:
            //            resultsList[i].ImagePath = "/Images/BestResults/2ndPlace.png";
            //            break;

            //        case 2:
            //            resultsList[i].ImagePath = "/Images/BestResults/3rdPlace.png";
            //            break;

            //        default:
            //            break;
            //    }
            //}

            return resultsList;
        }

        private void ShowResults(List<GameResult> resultsList) { Results_DataGrid.ItemsSource = resultsList; }
        #endregion RESULTS
    }
}
