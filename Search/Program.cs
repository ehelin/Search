using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearch s = new Search();
            IList<string> results = s.SearchFiles("file extension here", "path here");

            if (results != null && results.Count()>0)
                WriteResults(results);
        }

        private static void WriteResults(IList<string> results)
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\results.txt");

            try
            {
                foreach (string result in results)
                    sw.WriteLine(result);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    sw = null;
                }

            }
        }
    }
}
