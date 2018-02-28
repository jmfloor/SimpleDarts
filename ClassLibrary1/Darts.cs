using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts
{
    public class Dart
    {
        
        public int Score { get; set; }
        public int Band { get; set; }
        
        public void Throw(Random random)
        {
            Score = random.Next(0,21);
            
            if (random.Next(100) <= 5)
            {
                // 0 = no band
                // 1 = outerband
                // 2 = innerband

                this.Band = random.Next(2);
            }
            else this.Band = 0;
                        
        }

    }
}
