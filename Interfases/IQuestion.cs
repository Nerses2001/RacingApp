using System;


namespace RacingApp.Interfases
{
    internal interface IQuestion
    {
        string WhatIsYourName();
        string WhatIsYourCarName();

        void StartGame(bool start);

    }
}
