using Snake.Classes;
using Snake.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Snake.Pages.Game
{
    public partial class GamePage : Page
    {
        private readonly GameMenu gameMenu;

        private DispatcherTimer gameDispatcherTimer;
        private List<Rectangle> snake;
        private NormalFruit normalFruit;
        private Key LastKey = Key.Right;
        readonly Random rand = new Random();
        private int scoreFactor = 0;
        private int score = 0;

        public GamePage(GameMenu gameMenu)
        {
            InitializeComponent();
            this.gameMenu = gameMenu;

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.KeyDown += SnakeMove;
            gameDispatcherTimer = new DispatcherTimer(DispatcherPriority.Send);
            //gameDispatcherTimer = new DispatcherTimer();
            SetInformations();
            gameDispatcherTimer.Tick += Game;
            gameDispatcherTimer.Start();
        }

        private void GamePage_Loaded(object sender, RoutedEventArgs e)
        {
            MainGrid.DataContext = gameMenu;

            snake = new List<Rectangle>();

            #region INICJALIZACJA WĘŻA
            Rectangle rectangle = new Rectangle
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Colors.Green)
            };
            Playground.Children.Add(rectangle);

            //USTAWIENIE WĘŻA NA PLANSZY
            rectangle.SetValue(Canvas.TopProperty, 200.0);
            rectangle.SetValue(Canvas.LeftProperty, 200.0);
            #endregion

            snake.Add(rectangle);
            AddNewFruit();
        }

        private void AddNewFruit()
        {
            normalFruit = new NormalFruit();

            int X, Y;

            do
            {
                X = rand.Next(0, 20);
                Y = rand.Next(0, 20);
            } while (FruitCanCreate(X, Y));

            Playground.Children.Add(normalFruit);
            normalFruit.SetValue(Canvas.TopProperty, (double)(Y * 20));
            normalFruit.SetValue(Canvas.LeftProperty, (double)(X * 20));
        }

        private bool FruitCanCreate(int X, int Y)
        {
            return snake.Any(x =>
            {
                double elemX = (double)x.GetValue(Canvas.LeftProperty);
                double elemY = (double)x.GetValue(Canvas.TopProperty);

                if (X == elemX && Y == elemY) return true;
                return false;
            });
            //}) && specjalFruits.Any(x =>
            //{
            //    double elemX = (double)x.GetValue(Canvas.LeftProperty);
            //    double elemY = (double)x.GetValue(Canvas.TopProperty);

            //    if (X == elemX && Y == elemY)
            //        return true;
            //    return false;
            //});)
        }

        private void Game(object sender, EventArgs e)
        {

            for (int i = snake.Count - 1; i > 0; i--)
            {
                double x = (double)snake[i - 1].GetValue(Canvas.LeftProperty);
                double y = (double)snake[i - 1].GetValue(Canvas.TopProperty);
                snake[i].SetValue(Canvas.TopProperty, y);
                snake[i].SetValue(Canvas.LeftProperty, x);
            }

            //GŁOWA WĘŻA
            double X = (double)snake[0].GetValue(Canvas.LeftProperty);
            double Y = (double)snake[0].GetValue(Canvas.TopProperty);

            switch (LastKey)
            {
                case Key.Left:
                    X -= 20;
                    if (X < 0)
                    {
                        gameDispatcherTimer.Stop();
                        NavigationService.Navigate(new GameOverPage(gameMenu: gameMenu));
                    }
                    else
                    {
                        snake[0].SetValue(Canvas.TopProperty, Y);
                        snake[0].SetValue(Canvas.LeftProperty, X);
                    }
                    break;

                case Key.Right:
                    X += 20;
                    if (X >= 640)
                    {
                        gameDispatcherTimer.Stop();
                        NavigationService.Navigate(new GameOverPage(gameMenu: gameMenu));
                    }
                    else
                    {
                        snake[0].SetValue(Canvas.TopProperty, Y);
                        snake[0].SetValue(Canvas.LeftProperty, X);
                    }
                    break;

                case Key.Up:
                    Y -= 20;
                    if (Y < 0)
                    {
                        gameDispatcherTimer.Stop();
                        NavigationService.Navigate(new GameOverPage(gameMenu: gameMenu));
                    }
                    else
                    {
                        snake[0].SetValue(Canvas.TopProperty, Y);
                        snake[0].SetValue(Canvas.LeftProperty, X);
                    }
                    break;

                case Key.Down:
                    Y += 20;
                    if (Y >= 440)
                    {
                        gameDispatcherTimer.Stop();
                        NavigationService.Navigate(new GameOverPage(gameMenu: gameMenu));
                    }
                    else
                    {
                        snake[0].SetValue(Canvas.TopProperty, Y);
                        snake[0].SetValue(Canvas.LeftProperty, X);
                    }
                    break;


                default:
                    break;
            }

            var fruit = Playground.Children.OfType<UserControl>().FirstOrDefault(x =>
            {
                double elemX = (double)x.GetValue(Canvas.LeftProperty);
                double elemY = (double)x.GetValue(Canvas.TopProperty);

                if (X == elemX && Y == elemY)
                    return true;
                return false;

            });

            if (fruit is NormalFruit f)
            {
                score += scoreFactor;
                Points_TextBlock.Text = score.ToString();
                Playground.Children.Remove(f);
                AddSnakeElem();
                AddNewFruit();
            }
        }

        private void AddSnakeElem()
        {
            Rectangle rect = new Rectangle
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Colors.Green)
            };
            Playground.Children.Add(rect);

            double X = (double)snake[0].GetValue(Canvas.LeftProperty);
            double Y = (double)snake[0].GetValue(Canvas.TopProperty);

            rect.SetValue(Canvas.TopProperty, Y);
            rect.SetValue(Canvas.LeftProperty, X);
            snake.Add(rect);
        }

        private void SnakeMove(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    LastKey = Key.Left;
                    break;

                case Key.Right:
                    LastKey = Key.Right;
                    break;

                case Key.Up:
                    LastKey = Key.Up;
                    break;

                case Key.Down:
                    LastKey = Key.Down;
                    break;
            }
        }

        private void SetInformations()
        {
            if (gameMenu.OwnSettings)
            {
                DifficultyLevel_TextBlock.Text = "CUSTOMIZED";

                switch (gameMenu.SnakeSpeed)
                {
                    case Enums.SnakeSpeedEnum.Slow:
                        scoreFactor = 5;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);
                        break;

                    case Enums.SnakeSpeedEnum.Medium:
                        scoreFactor = 10;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(250);
                        break;

                    case Enums.SnakeSpeedEnum.Fast:
                        scoreFactor = 30;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(50);
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (gameMenu.Level)
                {
                    case Enums.LevelEnum.Easy:
                        DifficultyLevel_TextBlock.Text = "EASY";
                        scoreFactor = 5;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);

                        break;
                    case Enums.LevelEnum.Medium:
                        DifficultyLevel_TextBlock.Text = "MEDIUM";
                        scoreFactor = 10;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(230, 215, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(250);
                        break;

                    case Enums.LevelEnum.Hard:
                        DifficultyLevel_TextBlock.Text = "HARD";
                        scoreFactor = 20;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(153, 0, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
