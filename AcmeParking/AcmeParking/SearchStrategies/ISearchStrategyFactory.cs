using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeParking.Enum;

namespace AcmeParking.SearchStrategies
{
    public interface ISearchStrategyFactory
    {
        ISearchStrategy GetSearchStrategy(SearchType searchType);
    }
}
