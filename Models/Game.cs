using System;


namespace RacingApp.Models
{
    class Game
    {
        private bool _startGame;
        private readonly DateTime _gameTime;

        public Game(bool startGame)
        {
            this._startGame = startGame;
            _gameTime = DateTime.Now.Date.AddSeconds(60);
        }

        public bool StartGame 
        {
            get => _startGame;
            set 
            {
                if (_startGame != value) _startGame = value;
            }
        }
        public DateTime GetTime() => _gameTime;





    }
}
