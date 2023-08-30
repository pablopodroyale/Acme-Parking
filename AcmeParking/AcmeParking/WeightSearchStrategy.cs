using AcmeParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeParking
{
    public class WeightSearchStrategy : ISearchStrategy
    {

        public Car GetCar(SearchDTO search, Car[,] parkingSpots)
        {
            Car car = null;
            for (int i = 0; i < parkingSpots.GetLength(0); i++)
            {
                for (int j = 0; j < parkingSpots.GetLength(1); j++)
                {
                    if (parkingSpots[i, j] != null && parkingSpots[i,j].Weight == search.Weight)
                    {
                        car = parkingSpots[i, j];
                        parkingSpots[i, j] = null;
                        break;
                    }
                }

                if (car != null)
                {
                    break;
                }
            }

            return car;
        }
    }
}
