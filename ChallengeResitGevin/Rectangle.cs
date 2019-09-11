using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeResitGevin
{
    public class Rectangle : Quadilateral
    {
        public Rectangle(string Color, int S1, int S2) : base(Color, S1, S2, S1, S2)
        {
        }
        public int GetArea()
        {
            int area = Side1 * Side2;
            return area;
        }
    }
}
