using Snake.Classes;
using Snake.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
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
        #region VARIABLES AND OBJECTS
        #region GAME
        private readonly GameMenu gameMenu;
        private readonly DispatcherTimer gameDispatcherTimer;
        private int gameDelayMiliseconds;
        private List<Rectangle> snake;
        private NormalFruit normalFruit;
        private readonly Random rand = new Random();
        #endregion

        #region SPECIAL FRUIT
        private readonly DispatcherTimer specialFruitDispatcherTimer;
        private int specialFruitDelaySeconds;
        SpecialFruit specialFruit;
        private List<SpecialFruit> specialFruits;
        #endregion

        #region SCORE
        private int scoreFactor;
        private int score;
        private int scoreLength;
        #endregion

        #region NEW RECORD
        private List<GameResult> resultsList;
        private StreamReader streamReader;
        private int bestScore;
        private bool newRecord;
        #endregion

        #region SAVE TO .TXT FILE
        private string line;
        private DateTime dateTime;
        private StreamWriter streamWriter;
        #endregion

        #region KEYS
        private Key LastKey = Key.Right;
        private bool Right = true;
        private bool Top = false;
        private bool Bottom = false;
        private bool Left = false;
        #endregion
        #endregion

        public GamePage(GameMenu gameMenu)
        {
            InitializeComponent();
            this.gameMenu = gameMenu;

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.KeyDown += SnakeMove;

            //DispatcherPriority.Send - TOP PRIORITY
            gameDispatcherTimer = new DispatcherTimer(DispatcherPriority.Send);
            specialFruitDispatcherTimer = new DispatcherTimer(DispatcherPriority.Send);

            SetInformations();
        }

        private void GamePage_Loaded(object sender, RoutedEventArgs e)
        {
            MainGrid.DataContext = gameMenu;

            snake = new List<Rectangle>();
            specialFruits = new List<SpecialFruit>();

            NewRecord();

            dateTime = DateTime.Now;
            streamWriter = new StreamWriter("Results.txt", true);

            #region SNAKE INITIALISATION
            Rectangle rectangle = new Rectangle
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Colors.Green)
            };
            Playground.Children.Add(rectangle);

            //LOCATION OF THE HOSE ON THE BOARD
            rectangle.SetValue(Canvas.TopProperty, 200.0);
            rectangle.SetValue(Canvas.LeftProperty, 200.0);
            snake.Add(rectangle);
            #endregion

            AddNewFruit();

            gameDispatcherTimer.Tick += Game;
            specialFruitDispatcherTimer.Tick += AddSpecialFruit;
            gameDispatcherTimer.Start();
            specialFruitDispatcherTimer.Start();
        }

        #region ADDING FRUITS
        private void AddNewFruit()
        {
            normalFruit = new NormalFruit();

            int X, Y;

            do
            {
                X = rand.Next(0, 32);
                Y = rand.Next(0, 22);
            } while (!FruitCanCreate(X * 20, Y * 20));

            Playground.Children.Add(normalFruit);
            normalFruit.SetValue(Canvas.TopProperty, (double)(Y * 20));
            normalFruit.SetValue(Canvas.LeftProperty, (double)(X * 20));
        }

        private void AddSpecialFruit(object sender, EventArgs e)
        {
            specialFruit = new SpecialFruit();

            int X, Y;

            do
            {
                X = rand.Next(0, 32);
                Y = rand.Next(0, 22);
            } while (!FruitCanCreate(X * 20, Y * 20));

            Playground.Children.Add(specialFruit);
            specialFruits.Add(specialFruit);
            specialFruit.SetValue(Canvas.TopProperty, (double)(Y * 20));
            specialFruit.SetValue(Canvas.LeftProperty, (double)(X * 20));
        }

        private bool FruitCanCreate(int X, int Y)
        {
            double elemX, elemY;
            double fruitX = (double)normalFruit.GetValue(Canvas.LeftProperty);
            double fruitY = (double)normalFruit.GetValue(Canvas.TopProperty);

            return !snake.Any(x =>
            {
                elemX = (double)x.GetValue(Canvas.LeftProperty);
                elemY = (double)x.GetValue(Canvas.TopProperty);

                if (X == elemX && Y == elemY) return true;
                return false;

            }) && !specialFruits.Any(x =>
            {
                elemX = (double)x.GetValue(Canvas.LeftProperty);
                elemY = (double)x.GetValue(Canvas.TopProperty);

                if (X == elemX && Y == elemY) return true;
                return false;
            }) && fruitX != X && fruitY != Y;
        }
        #endregion

        #region GAME
        private void Game(object sender, EventArgs e)
        {
            double x, y;

            for (int i = snake.Count - 1; i > 0; i--)
            {
                x = (double)snake[i - 1].GetValue(Canvas.LeftProperty);
                y = (double)snake[i - 1].GetValue(Canvas.TopProperty);
                snake[i].SetValue(Canvas.LeftProperty, x);
                snake[i].SetValue(Canvas.TopProperty, y);
            }

            //GŁOWA WĘŻA
            double X = (double)snake[0].GetValue(Canvas.LeftProperty);
            double Y = (double)snake[0].GetValue(Canvas.TopProperty);

            switch (LastKey)
            {
                case Key.Left:
                    X -= 20;
                    if (X < 0 || TailHitted(X, Y)) GameOver();
                    else SnakeHead(X: X, Y: Y);
                    break;

                case Key.Right:
                    X += 20;
                    if (X >= 640 || TailHitted(X, Y)) GameOver();
                    else SnakeHead(X: X, Y: Y);
                    break;

                case Key.Up:
                    Y -= 20;
                    if (Y < 0 || TailHitted(X, Y)) GameOver();
                    else SnakeHead(X: X, Y: Y);
                    break;

                case Key.Down:
                    Y += 20;
                    if (Y >= 440 || TailHitted(X, Y)) GameOver();
                    else SnakeHead(X: X, Y: Y);
                    break;

                default:
                    break;
            }

            var fruit = Playground.Children.OfType<UserControl>().FirstOrDefault(i =>
            {
                double elemX = (double)i.GetValue(Canvas.LeftProperty);
                double elemY = (double)i.GetValue(Canvas.TopProperty);

                if (X == elemX && Y == elemY) return true;
                return false;
            });

            if (fruit is NormalFruit normal)
            {
                AddSnakeElem();
                Playground.Children.Remove(normal);
                AddNewFruit();
                score += scoreFactor;
                Points_TextBlock.Text = score.ToString();

                if (!gameMenu.OwnSettings)
                {
                    if (gameDelayMiliseconds > 50)
                    {
                        gameDelayMiliseconds -= 5;
                        gameDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, gameDelayMiliseconds);
                    }
                }
            }
            else if (fruit is SpecialFruit special)
            {
                AddSnakeElem();
                AddSnakeElem();
                Playground.Children.Remove(special);
                specialFruits.Remove(special);
                score += 50;
                Points_TextBlock.Text = score.ToString();

                if (!gameMenu.OwnSettings)
                {
                    if (gameDelayMiliseconds > 50)
                    {
                        gameDelayMiliseconds -= 10;
                        gameDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, gameDelayMiliseconds);
                    }
                }
            }
        }

        private bool TailHitted(double X, double Y)
        {
            for (int i = 1; i < snake.Count; i++)
            {
                if (X == (double)snake[i].GetValue(Canvas.LeftProperty) &&
                    Y == (double)snake[i].GetValue(Canvas.TopProperty)) return true;
            }

            return false;
        }

        private void SnakeHead(double X, double Y)
        {
            snake[0].SetValue(Canvas.LeftProperty, X);
            snake[0].SetValue(Canvas.TopProperty, Y);
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

        #region MOVING THE SNAKE
        private void SnakeMove(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    if (!Right)
                    {
                        if (Left) break;
                        else
                        {
                            LastKey = Key.Left;
                            Left = true;
                            Right = false;
                            Top = false;
                            Bottom = false;
                        }
                    }
                    break;

                case Key.Right:
                    if (!Left)
                    {
                        if (Right) break;
                        else
                        {
                            LastKey = Key.Right;
                            Right = true;
                            Left = false;
                            Top = false;
                            Bottom = false;
                        }
                    }
                    break;

                case Key.Up:
                    if (!Bottom)
                    {
                        if (Top) break;
                        else
                        {
                            LastKey = Key.Up;
                            Top = true;
                            Left = false;
                            Right = false;
                            Bottom = false;
                        }
                    }
                    break;

                case Key.Down:
                    if (!Top)
                    {
                        if (Bottom) break;
                        else
                        {
                            LastKey = Key.Down;
                            Bottom = true;
                            Top = false;
                            Left = false;
                            Right = false;
                        }
                    }
                    break;
            }
            #endregion
        }
        #endregion

        #region GAME OVER
        private void GameOver()
        {
            specialFruitDispatcherTimer.Stop();
            gameDispatcherTimer.Stop();

            scoreLength = score.ToString().Length;

            switch (scoreLength)
            {
                case 1:
                    if (gameMenu.OwnSettings) line = "000" + score.ToString() + " " + gameMenu.Nickname + " " + "CUSTOMIZED" + " " + dateTime.ToShortDateString().ToString();
                    else line = "000" + score.ToString() + " " + gameMenu.Nickname + " " + gameMenu.Level.ToString().ToUpper() + " " + dateTime.ToShortDateString().ToString();
                    streamWriter.WriteLine(line);
                    streamWriter.Close();
                    break;

                case 2:
                    if (gameMenu.OwnSettings) line = "00" + score.ToString() + " " + gameMenu.Nickname + " " + "CUSTOMIZED" + " " + dateTime.ToShortDateString().ToString();
                    else line = "00" + score.ToString() + " " + gameMenu.Nickname + " " + gameMenu.Level.ToString().ToUpper() + " " + dateTime.ToShortDateString().ToString();
                    streamWriter.WriteLine(line);
                    streamWriter.Close();
                    break;

                case 3:
                    if (gameMenu.OwnSettings) line = "0" + score.ToString() + " " + gameMenu.Nickname + " " + "CUSTOMIZED" + " " + dateTime.ToShortDateString().ToString();
                    else line = "0" + score.ToString() + " " + gameMenu.Nickname + " " + gameMenu.Level.ToString().ToUpper() + " " + dateTime.ToShortDateString().ToString();
                    streamWriter.WriteLine(line);
                    streamWriter.Close();
                    break;

                case 4:
                    if (gameMenu.OwnSettings) line = score.ToString() + " " + gameMenu.Nickname + " " + "CUSTOMIZED" + " " + dateTime.ToShortDateString().ToString();
                    else line = score.ToString() + " " + gameMenu.Nickname + " " + gameMenu.Level.ToString().ToUpper() + " " + dateTime.ToShortDateString().ToString();
                    streamWriter.WriteLine(line);
                    streamWriter.Close();
                    break;

                default:
                    break;
            }

            newRecord = score > bestScore;
            NavigationService.Navigate(new GameOverPage(gameMenu: gameMenu, score: score, newRecord: newRecord));
        }

        private void NewRecord()
        {
            resultsList = new List<GameResult>();
            streamReader = new StreamReader("Results.txt");
            string readLine;

            while ((readLine = streamReader.ReadLine()) != null)
            {
                string[] row = readLine.Split(' ');
                resultsList.Add(new GameResult(ImagePath: null, Place: "", Score: row[0], Nickname: row[1], DifficultyLevel: row[2], Date: row[3]));
            }
            streamReader.Close();

            resultsList.Sort((GameResult x, GameResult y) => y.Score.CompareTo(x.Score));

            if (resultsList.Count == 0) newRecord = true;
            else bestScore = Convert.ToInt32(resultsList[0].Score);
        }
        #endregion

        #region SET INFORMATIONS
        private void SetInformations()
        {
            if (gameMenu.OwnSettings)
            {
                DifficultyLevel_TextBlock.Text = "CUSTOMIZED";

                switch (gameMenu.BonusFruit)
                {
                    case Enums.BonusFruitFrequencyEnum.Rarely:
                        specialFruitDelaySeconds = 8;
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    case Enums.BonusFruitFrequencyEnum.Normally:
                        specialFruitDelaySeconds = 5;
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    case Enums.BonusFruitFrequencyEnum.Often:
                        specialFruitDelaySeconds = 3;
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    case Enums.BonusFruitFrequencyEnum.VeryOften:
                        specialFruitDelaySeconds = 1;
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    default:
                        break;
                }

                switch (gameMenu.SnakeSpeed)
                {
                    case Enums.SnakeSpeedEnum.Slow:
                        scoreFactor = 5;
                        gameDelayMiliseconds = 300;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        break;

                    case Enums.SnakeSpeedEnum.Medium:
                        scoreFactor = 10;
                        gameDelayMiliseconds = 200;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        break;

                    case Enums.SnakeSpeedEnum.Fast:
                        scoreFactor = 30;
                        gameDelayMiliseconds = 100;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        break;

                    case Enums.SnakeSpeedEnum.VeryFast:
                        scoreFactor = 50;
                        gameDelayMiliseconds = 50;
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
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
                        gameDelayMiliseconds = 300;
                        specialFruitDelaySeconds = 3;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);

                        break;
                    case Enums.LevelEnum.Medium:
                        DifficultyLevel_TextBlock.Text = "MEDIUM";
                        scoreFactor = 10;
                        gameDelayMiliseconds = 200;
                        specialFruitDelaySeconds = 5;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(230, 215, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    case Enums.LevelEnum.Hard:
                        DifficultyLevel_TextBlock.Text = "HARD";
                        scoreFactor = 20;
                        gameDelayMiliseconds = 100;
                        specialFruitDelaySeconds = 8;
                        DifficultyLevel_TextBlock.Foreground = new SolidColorBrush(Color.FromRgb(153, 0, 0));
                        gameDispatcherTimer.Interval = TimeSpan.FromMilliseconds(gameDelayMiliseconds);
                        specialFruitDispatcherTimer.Interval = TimeSpan.FromSeconds(specialFruitDelaySeconds);
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
