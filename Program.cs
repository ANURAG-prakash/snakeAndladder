using System;

namespace UC4_toReach100
{
    class Program
    {
        static void Main(string[] args)
        {
            int PLAYER_POSITION = 0;
            while (PLAYER_POSITION != 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Random random1 = new Random();
                int choice = random1.Next(0, 3);
                if (choice == 0)
                    PLAYER_POSITION += 0;
                else if (choice == 1)
                    PLAYER_POSITION += dice;
                else if (choice == 2)
                    if (PLAYER_POSITION < dice)
                        PLAYER_POSITION = 0;
                    else
                        PLAYER_POSITION = PLAYER_POSITION - dice;
            }
        }
    }
}
