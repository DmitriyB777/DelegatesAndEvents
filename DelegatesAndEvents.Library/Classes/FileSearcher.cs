using DelegatesAndEvents.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Library.Classes
{
    public class FileSearcher : IFileSearcher
    {
        public bool CancelSearch { get; set; }

        public event EventHandler<FileArgs> FileFound;

        public void OnFileFound(string fileName)
        {
            var handler = FileFound;
            handler?.Invoke(this, new FileArgs(fileName));
        }

        public void SearchFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                if (CancelSearch)
                {
                    Console.WriteLine("The search was canceled from the event handler.");
                    break;
                }

                OnFileFound(Path.GetFileName(file));
            }
        }
    }
}
