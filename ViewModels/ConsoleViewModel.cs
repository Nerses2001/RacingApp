using RacingApp.Interfases;
using RacingApp.Models;
using System;

namespace RacingApp.ViewModels
{
    internal class ConsoleViewModel : IQuestion
    {
        private readonly ConsoleComands _kConsole;

       
        public ConsoleViewModel() 
        {
            string name = ((IQuestion)this).WhatIsYourName();
            string carName = ((IQuestion)this).WhatIsYourCarName();
            _kConsole = new ConsoleComands(name, carName);
            ((IQuestion)this).StartGame(true);
        }

        public ConsoleComands KConsole { get { return _kConsole; } }

        void IQuestion.StartGame(bool start)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please press enter to play the game");
            Console.ReadLine();
            Console.Clear();

        }

        string IQuestion.WhatIsYourCarName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your car name:");
            string carName = Console.ReadLine();
            return carName;
        }

        string IQuestion.WhatIsYourName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

       
    }
}
