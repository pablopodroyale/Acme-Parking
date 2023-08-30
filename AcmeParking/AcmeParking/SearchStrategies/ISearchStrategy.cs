using AcmeParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeParking.SearchStrategies
{
    public interface ISearchStrategy
    {
        public abstract Car GetCar(SearchDTO search, Car[,] parkingSpots);
    }
}
