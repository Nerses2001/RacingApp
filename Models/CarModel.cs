
namespace RacingApp.Models
{
    internal class CarModel
    {
        
        private readonly string _name;
        private readonly string _car;
        
        public string Name => _name;
        public string Car => _car;

        public CarModel(string name)
        {
            this._car = "|*CAR*|";

            
            if (name.Length == 0) this._name = "User1";
            else this._name = name;

        }


    }
}
