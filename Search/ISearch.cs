using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public interface ISearch
    {
        IList<string> SearchFiles(string searchTerm, string startDirectory);
    }
}
