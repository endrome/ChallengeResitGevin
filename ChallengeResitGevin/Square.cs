using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeResitGevin
{
    public class Square : Quadilateral
    {
        public Square(string Color, int S1) : base(Color, S1, S1, S1, S1)
        {
        }
        public int GetArea()
        {
            int area = Side1 * Side1;
            return area;
        }
    }
}
