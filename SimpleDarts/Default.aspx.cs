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
            Game game = new Game("Player One","Player Two");
            string result = game.Play();

            resultLabel.Text = result;
            
    }
}