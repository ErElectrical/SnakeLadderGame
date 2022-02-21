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
        public static int firstPlayerPosition = 0;
        public static int SecondPlayerPosition = 0;
        public static bool PlayerOneFlag = true;
        public static bool FirstPlayerFlag = true;
        public static bool SecondPlayerFlag = true;
        public static int PlayerChance = 1;

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
        public void SinglePlayerCheckOption()
        {
            int countRoll = 0;

            while (PlayerOneFlag != false)
            {
               

                Random rem = new Random();
                int option = rem.Next(0, 2);
                countRoll++;
                if (option == 0)
                {
              
                    position += 0;
                }
                else if(option == 1)
                {
                  
                    int value = getrolldievalue();
                    if(position + value > 100)
                    {
                        position += 0;
                    }
                    else
                    {
                        position += value;
                    }
                }
                else
                {
                   
                    int value = getrolldievalue();
                    if(position-value > 0)
                    {
                        position -= value;

                    }
                    else
                    {
                        position = 0;
                    }
                }
                if(position == 100 )
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

        private void GetPlayerChance()
        {
            if(PlayerChance % 2 != 0)
            {
                Console.WriteLine("Player 1 chance");

            }
            else
            {
                Console.WriteLine("player 2 chance");
            }
        }
        public void TwoPlayerCheckOption()
        {
            int FirstPlayerRollCount = 0;
            int SecondPlayerRollCount = 0;
            while(FirstPlayerFlag != false || SecondPlayerFlag != false)
            {
                Random rem = new Random();
                int option = rem.Next(0, 2);
                GetPlayerChance();
               
                if(PlayerChance % 2 != 0 ||PlayerChance % 2 != 0 && option == 1)
                {
                    int value=getrolldievalue();
                    firstPlayerPosition++;
                    if(option == 0 )
                    {
                        firstPlayerPosition += 0;
                    }
                    else if( option == 1)
                    {
                        if(firstPlayerPosition + value > 100)
                        {
                            firstPlayerPosition += 0;


                        }
                        else
                        {
                            firstPlayerPosition += value;
                        }

                    }
                    else if(option == 2)
                    {
                        if(firstPlayerPosition - value > 0)
                        {
                            firstPlayerPosition -= value;
                        }
                        else
                        {
                            firstPlayerPosition = 0;
                        }
                    }
                    if(firstPlayerPosition == 100)
                    {
                        FirstPlayerFlag = false;
                        break;
                    }
                    PlayerChance++;
                }

                else if(PlayerChance % 2 == 0 || PlayerChance %2 == 0 && option == 1)
                {
                    int value = getrolldievalue();
                    SecondPlayerRollCount++;
                    if(option == 0)
                    {
                        SecondPlayerPosition += 0;
                    }
                    else if(option == 1)
                    {
                        if(SecondPlayerPosition + value > 100)
                        {
                            SecondPlayerPosition += 0;
                        }
                        else
                        {
                            SecondPlayerPosition += value;
                        }

                    }
                    else if(option == 2)
                    {
                        if(SecondPlayerPosition - value > 0)
                        {
                            SecondPlayerPosition -= value;
                        }
                        else
                        {
                            SecondPlayerPosition = 0;
                        }
                    }
                    if(SecondPlayerPosition == 100)
                    {
                        SecondPlayerFlag = false;
                        break;
                    }
                    PlayerChance++;


                }

            }
            GameAnnouncementTwoPlayer(FirstPlayerRollCount, SecondPlayerRollCount);
        }
        
        private static void GameAnnouncementTwoPlayer(int fc, int sc)
        {
            if(FirstPlayerFlag == false && firstPlayerPosition > SecondPlayerPosition)
            {
                Console.WriteLine("Player 1 won ");
                Console.Write($"take {fc} dice roll ");
            }
            else if(SecondPlayerFlag == false && SecondPlayerPosition > firstPlayerPosition)
            {
                Console.WriteLine("player 2 won");
                Console.WriteLine($"take {sc} dice roll");
            }
        }
                    
    }
}
