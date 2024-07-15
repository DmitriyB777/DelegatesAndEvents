using DelegatesAndEvents.Library.Classes;
using DelegatesAndEvents.Library.Extensions;
using DelegatesAndEvents.Library.Interfaces;

namespace DelegatesAndEvents.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list = new List<string>
                {
                    "-101", "101", "13", "4"
                };

                Console.WriteLine($"Max value = {list.GetMax((l) => Convert.ToSingle(l))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }

            IFileSearcher fileSearcher = new FileSearcher();
            fileSearcher.FileFound += (sender, e) =>
            {
                Console.WriteLine($"File found: {e.FileName}");

                if (e.FileName.ToUpper() == "test.txt".ToUpper())
                {
                    fileSearcher.CancelSearch = true;
                }
            };

            fileSearcher.SearchFiles("C:\\test");

            Console.ReadKey();
        }
    }
}
