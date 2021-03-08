using System;

namespace UC6_postion
{
    public class program
    {
        public static int playerDiceRoll()
        {
            int PLAYER_POSITION = 0; int count = 0;
            while (PLAYER_POSITION != 100)
            {
                count++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                Random random1 = new Random();
                int choice = random1.Next(0, 3);
                if (choice == 0)
                    PLAYER_POSITION += 0;
                else if (choice == 1)
                    if ((PLAYER_POSITION + dice) <= 100)
                        PLAYER_POSITION += dice;
                    else
                        PLAYER_POSITION += 0;
                else if (choice == 2)
                    if (PLAYER_POSITION < dice)
                        PLAYER_POSITION = 0;
                    else
                        PLAYER_POSITION = PLAYER_POSITION - dice;

            }

            return count;
        }
        public static void Main(String[] arg)
        {
           int player1 = playerDiceRoll() ;
            int player2 = playerDiceRoll();
            if (player1 > player2)
                Console.WriteLine("second player has won");
            else
                Console.WriteLine("first player has won");
        }
    }
}