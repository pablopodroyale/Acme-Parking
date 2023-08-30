using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeParking
{
    public interface ISearchStrategyFactory
    {
        ISearchStrategy GetSearchStrategy(SearchType searchType);
    }
}
