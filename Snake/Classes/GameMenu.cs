using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Classes
{
    public class GameMenu
    {
        #region DIFFICULTY LEVEL
        public LevelEnum Level { get; set; }
        #endregion

        #region OWN SETTINGS
        public bool OwnSettings { get; set; }
        public SnakeSpeedEnum SnakeSpeed { get; set; }
        public BonusFruitFrequencyEnum BonusFruit { get; set; }
        #endregion

        #region MUSIC
        private SoundPlayer SoundPlayer;

        //public string LastPath { get; set; }
        public string MusicPath { get; set; }
        public bool MusicOn { get; set; }
        #endregion

        #region GAME
        public string Nickname { get; set; }
        #endregion

        public GameMenu() { }

        public GameMenu(LevelEnum Level, bool OwnSettings, SnakeSpeedEnum SnakeSpeed, BonusFruitFrequencyEnum BonusFruit,
            string MusicPath, bool MusicOn)
        {
            this.Level = Level;
            this.OwnSettings = OwnSettings;
            this.SnakeSpeed = SnakeSpeed;
            this.BonusFruit = BonusFruit;
            this.MusicPath = MusicPath;
            this.MusicOn = MusicOn;
        }

        public void PlayMusic()
        {
            SoundPlayer = new SoundPlayer(MusicPath);
            SoundPlayer.PlayLooping();
            MusicOn = true;
        }

        public void StopMusic()
        {
            SoundPlayer.Stop();
            MusicOn = false;
        }
    }
}
