using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeParking.Enum;

namespace AcmeParking.SearchStrategies
{
    internal class SearchStrategyFactory : ISearchStrategyFactory
    {
        public ISearchStrategy GetSearchStrategy(SearchType searchType)
        {
            ISearchStrategy? searchStrategy = null;

            switch (searchType)
            {
                case SearchType.WEIGHT:
                    searchStrategy = new WeightSearchStrategy();
                    break;
                case SearchType.REGISTRATION_NUMBER:
                    searchStrategy = new RegistrationNumberSearchStrategy();
                    break;
                default:
                    throw new Exception("Search unsuported");
            }

            return searchStrategy;
        }
    }
}
