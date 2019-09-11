using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeResitGevin
{
    public class InvalidIntException : Exception
    {
        public InvalidIntException(string message) : base("ERROR: The length given was less than 1 or greater than 100")
        {

        }
    }
}
