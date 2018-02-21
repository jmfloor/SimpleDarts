using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();

        public int Score { get; set; }
        public int Band { get; set; }


        public void Throw()
        {
            Score = this.random.Next(20);
            
            if (random.Next(100) <= 5)
            {
                this.Band = random.Next(2);
            }
            else this.Band = 0;
            
            //comment
        }

    }
}
