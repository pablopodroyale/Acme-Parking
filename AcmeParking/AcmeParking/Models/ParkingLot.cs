using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeParking.Enum;
using AcmeParking.SearchStrategies;

namespace AcmeParking.Models
{
    public class ParkingLot
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Car[,] ParkingSpots { get; set; }
        private readonly ISearchStrategyFactory SearchStrategyFactory;

        public ParkingLot(int height, int width, ISearchStrategyFactory searchStrategyFactory)
        {
            ParkingSpots = new Car[height, width];
            SearchStrategyFactory = searchStrategyFactory;
        }

        public void SetCar(Car car)
        {
            bool isSet = false;
            for (int i = 0; i < ParkingSpots.GetLength(0); i++)
            {
                for (int j = 0; j < ParkingSpots.GetLength(1); j++)
                {
                    if (ParkingSpots[i, j] == null)
                    {
                        ParkingSpots[i, j] = car;
                        isSet = true;
                        break;
                    }
                }
                if (isSet)
                {
                    break;
                }
            }
        }

        internal Car GetCar(SearchType searchType, SearchDTO search)
        {
            ISearchStrategy searchStrategy = SearchStrategyFactory.GetSearchStrategy(searchType);   
            return searchStrategy.GetCar(search, ParkingSpots);
        }
    }
}
