using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakevsLadder
{
    public class SnakeLadderLogic
    {
        int position = 0;

        private int getrolldievalue()
        {
            Random random = new Random();
            int dievalue = random.Next(1, 6);
            return dievalue;
        }
    }
}
