using System;
using RacingApp.Interfases;
using RacingApp.Models;


namespace RacingApp.ViewModels
{
    internal class RouteViewModel :  IMoveRoute
    {
        //    private int _position;
        private bool _stop; 
        private int _left;
        private readonly int _top;
        private readonly  RouteModel _route;
        private readonly Random random = new Random();
        private readonly CarModel _car;



        public RouteViewModel() 
        {
            _route =  new RouteModel(40);
            _left = 1;
            _top = 0;
            _stop = false;
      //      _position = 15;
            _car = new CarModel("");
        }




        private void StartGame()
        {
            Console.WriteLine("Press Enter to play the game");
            Console.ReadLine();
            Console.Clear();
        }

        private void MoveRoute(ref int index, ref string mid)
        {


            Console.SetCursorPosition(this._top, this._left);
            this._left += 2;
            Console.WriteLine(this._route.Route);
            Console.SetCursorPosition(this._top + 1, index++);
            Console.WriteLine(mid + "                              ");
            
            if (_left == 27) this._left = 1;
            if (index == 27) index = 1;
        }

        private void ChangeColor(ref int tmp) 
        {
            if (this._left == tmp + 1) Console.ForegroundColor = ConsoleColor.Green;
            else if (this._left == tmp + 2) Console.ForegroundColor = ConsoleColor.White;

            else if (this._left == tmp + 3) Console.ForegroundColor = ConsoleColor.Cyan;
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                tmp = this._left + random.Next(0, 3);
            }
        }
        public void Move()
        {
            int _position = 15;
            string mid = new string(' ', _route.Route.Length / 2 ) + "|";
            int tmp = this._left;
            int index = 1;
            // ConsoleKeyInfo keyInfo;
            StartGame();
            while (!_stop) 
            {
                MoveRoute(ref index, ref mid);
                ChangeColor(ref tmp);
                //        Thread.Sleep(100)
                MoveCar(ref _position);


            }
            Console.Clear();    
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!!");
            
        }
        private void MoveCar(ref int position)
        {

            Console.SetCursorPosition(position, 14);
            Console.Write(_car.Car);
            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.RightArrow)

                {
                    position += 6;
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    position -= 6;
                }
            }
            if(position <= 0 || position > 33) 
            {

            //    Console.ReadLine();
                _stop = true;
   
            } 
            
        }
        
    }
}
