﻿using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        //Returns Output Of Die Roll
        public static int rollTheDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        //Returns Increment Or Decrement to be Made with Current Position
        public static int newPosition(int numberOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toDo = random.Next(1, 4);
            switch (toDo)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    toAdd = numberOnDie;
                    break;
                case SNAKE:
                    toAdd = -numberOnDie;
                    break;
            }
            return toAdd;
        }
        static void Main(string[] args)
        {
            int currentPosition = 0;
            //Rolling Die
            int numberOnDie = rollTheDie();
            //checking for an option out of three
            int toAdd = newPosition(numberOnDie);
        }
    }
}