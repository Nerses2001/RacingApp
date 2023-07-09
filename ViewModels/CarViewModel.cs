using RacingApp.Interfases;
using RacingApp.Models;
using System;

namespace RacingApp.ViewModels
{
    internal class CarViewModel: IChangeCarPosition
    {
        private int _position;
        private readonly CarModel _car;
        


        public CarViewModel() 
        {
           this._car = new CarModel("Mercedes-Benz");
            this._position = 15;
        }

        public void ChangeCarPosition(int size)
        {
            if(Math.Abs(size) < 5)  size = 5;
            

            Console.SetCursorPosition(_position, 28);
            Console.WriteLine(_car.Car);
            _position += size;
        }
    }
}
