using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameResult
    {
        public string ImagePath { get; set; }
        public string Place { get; set; }
        public string Score { get; set; }
        public string Nickname { get; set; }
        public string DifficultyLevel { get; set; }
        public string Date { get; set; }

        public GameResult() { }

        public GameResult(string ImagePath, string Place, string Score, string Nickname, string DifficultyLevel, string Date)
        {
            this.ImagePath = ImagePath;
            this.Place = Place;
            this.Score = Score;
            this.Nickname = Nickname;
            this.DifficultyLevel = DifficultyLevel;
            this.Date = Date;
        }
    }
}
