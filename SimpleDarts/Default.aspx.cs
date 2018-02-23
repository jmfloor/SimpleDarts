using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace SimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void runButton_Click(object sender, EventArgs e)
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Dart playDart = new Dart();

            
            do
            {
                playerOne.IncreaseScore(score(playDart));
                playerTwo.IncreaseScore(score(playDart));


            } while (playerOne.Score < 300 & playerTwo.Score < 300);

            string winner = "";

            if (playerOne.Score > playerTwo.Score) winner = "Player One";
            else winner = "Player Two";

            resultLabel.Text = String.Format("Player One score: {0} <br /> Player Two Score: {1} <br /> The winner is: {2} <br />",
                playerOne.Score.ToString(),
                playerTwo.Score.ToString(),
                winner);

        }

        private int score(Dart dart)
        {
            dart.Throw();   
            if (dart.Score == 0) {
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
}