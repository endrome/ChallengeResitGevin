using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeResitGevin
{
    public class Quadilateral : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public Quadilateral(string Color, int S1, int S2, int S3, int S4) : base(Color)
        {
            if (S1 < 1)
            {   
                throw (new InvalidIntException(""));
            }

            if (S2 < 1)
            {
                throw (new InvalidIntException(""));
            }

            if (S3 < 1)
            {
                throw (new InvalidIntException(""));
            }

            if (S4 < 1)
            {
                throw (new InvalidIntException(""));
            }

            Side1 = S1;
            Side2 = S2;
            Side3 = S3;
            Side4 = S4;
        }

        public int GetPerimeter()
        {
            int perimeter = Side1 + Side2 + Side3 + Side4;
            return perimeter;
        }
    }
}
    

