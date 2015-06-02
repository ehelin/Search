using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Search
{
    public class Search : ISearch
    {
        public IList<string> SearchFiles(string searchTerm, string startDirectory)
        {
            IList<string> results = new List<string>();

            results = GetResults(searchTerm, startDirectory, results);

            return results;
        }

        private IList<string> GetResults(string searchTerm, string startDirectory, IList<string> results)
        {
            string[] files = null;
            string[] directories = null;

            try
            {
                files = Directory.GetFiles(startDirectory);
                directories = Directory.GetDirectories(startDirectory);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (string file in files)
                if (file.IndexOf(searchTerm) != -1)
                    results.Add(file);

            foreach (string directory in directories)
                results = GetResults(searchTerm, directory, results);

            return results;
        }
    }
}
