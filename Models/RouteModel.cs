
namespace RacingApp.Models
{
    internal class RouteModel
    {
        private readonly int _weight;
        private string _route;

        public int Weight => _weight;
        public string Route => _route;

        public RouteModel(int weight) 
        {
            if (weight < 10) this._weight = 10;
            else this._weight = weight;

            GenerateRoute();

        }

        private void GenerateRoute() 
        {
            this._route = "|";

            for(int i = 0; i < this._weight - 2; ++i) 
            {
               
                this._route = $"{this._route} ";
            }
            this._route = $"{this._route}|";
            }

    }
}
