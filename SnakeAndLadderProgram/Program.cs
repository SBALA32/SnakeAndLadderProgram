using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        //Returns Output Of Die Roll
        public static int rollTheDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        static void Main(string[] args)
        {
            int currentPosition = 0;
            int numberOnDie = rollTheDie();
        }
    }
}