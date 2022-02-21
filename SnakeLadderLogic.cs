using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeLadderGame
{
    public class SnakeLadderLogic
    {
        public int position = 0;
        public static bool PlayerOneFlag = true;

        /// <summary>
        /// Method give us the random number every time we roll the dice
        /// </summary>
        /// <returns></returns>
        private int getrolldievalue()
        {
            Random random = new Random();
            int dievalue = random.Next(1, 6);
            return dievalue;
        }

        /// <summary>
        /// method check in game of player
        /// </summary>
        public void PlayerCheckOption()
        {
            int countRoll = 0;

            while (PlayerOneFlag != false)
            {
               

                Random rem = new Random();
                int option = rem.Next(0, 2);
                countRoll++;
                if (option == 0)
                {
                    Console.WriteLine("No Play");
                    position += 0;
                }
                else if(option == 1)
                {
                    Console.WriteLine("Ladder Achieve ");
                    int value = getrolldievalue();
                    position += value;
                }
                else
                {
                    Console.WriteLine("Snake bite");
                    int value = getrolldievalue();
                    position -= value;
                }
                if(position < 0)
                {
                    position = 0;
                }
                if(position == 100 || position > 100)
                {
                    PlayerOneFlag = false;
                    break;
                }
            }
            PlayerOneGameAnnouncment(countRoll);
        }

        private void PlayerOneGameAnnouncment(int chances)
        {
            if(PlayerOneFlag == false)
            {
                Console.WriteLine($" you won in { chances } chances");
            }
        }
                    
    }
}
