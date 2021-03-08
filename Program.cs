using System;

namespace UC2_LadderSnake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int choice = random.Next(0, 3);
            if (choice == 0)
                Console.WriteLine("no movement");
            else if (choice == 1)
                Console.WriteLine("is ladder player move a head");
            else if (choice == 2)
                Console.WriteLine("is snake player move back");
        }
    }
}
