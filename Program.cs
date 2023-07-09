using System;
using RacingApp.Models;
using RacingApp.ViewModels;

namespace RacingApp
{


    class Program
    {
        static void Main()
        {
            RouteViewModel routeViewModel = new RouteViewModel();
            routeViewModel.Move();
            Console.ReadLine();

        }
    }

}