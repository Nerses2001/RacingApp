using RacingApp.Models;
using RacingApp.ViewModels;
using System;

namespace RacingApp.View
{
    internal class MainView
    {
        private readonly ConsoleViewModel _kConsole;
        private readonly CarViewModel _carViewModel;
        private readonly RouteViewModel _routeViewModel;
        private readonly User _user;

        public MainView() 
        {
            this._kConsole = new ConsoleViewModel();
            this._carViewModel = new CarViewModel(_kConsole.KConsole.CarName);
            this._routeViewModel = new RouteViewModel();
            this._user = new User(15,_kConsole.KConsole.UsserName,100); 
        }
        public void StartView()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"User name is {_user.UserName}, Id is {_user.UserId} Car name is {_kConsole.KConsole.CarName}");
        
            int tmp = _routeViewModel.Left;
            while (!_carViewModel.GameOver) 
            {
                _routeViewModel.Move();
                _routeViewModel.ChangeColor(ref tmp);
                _carViewModel.Move();
            }

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("GAME OVER !!!");
        }


    }
}
