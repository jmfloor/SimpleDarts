using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;


namespace SimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

       // public string Play { get; internal set; }

        public Game(string PlayerOne, string PlayerTwo)
        {
            _player1 = new Player();
            _player1.PlayerName = PlayerOne;

            _player2 = new Player();
            _player2.PlayerName = PlayerTwo;

            _random = new Random();

            

        }

        public string Play()
        {
            Dart _dart = new Dart(); 

            while (_player1.Score < 300 & _player2.Score < 300)
                {
                    _player1.Score += Score(_dart);
                    _player2.Score += Score(_dart);

                }
            
            return printResults(_player1,_player2);

        }

        private string printResults(Player player1, Player player2)
        {
            string winner = (_player1.Score > _player2.Score) ?winner = "Player One" 
                : winner = "Player Two";

            return String.Format("Player One score: {0} <br /> Player Two Score: {1} <br /> The winner is: {2} <br />",
                _player1.Score.ToString(),
                _player2.Score.ToString(),
                winner);
            
        }

        private int Score(Dart dart)
        {
            dart.Throw(_random);

            if (dart.Score == 0)
            {
                if (dart.Band == 2) return 50;
                else return 25;
            }
            else
            {
                if (dart.Band == 2) return dart.Score * 3;
                else if (dart.Band == 1) return dart.Score * 2;
                else return dart.Score;
            }

        }
    }


    public class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
           
    }

    
}