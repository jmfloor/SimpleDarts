using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDarts
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public void IncreaseScore(int score)
        {
            this.Score += score;
        }

    }

    
}