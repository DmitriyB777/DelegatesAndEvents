using DelegatesAndEvents.Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Library.Interfaces
{
    public interface IFileSearcher
    {
        event EventHandler<FileArgs> FileFound;
        bool CancelSearch { get; set; }
        void SearchFiles(string directoryPath);
        void OnFileFound(string fileName);
    }
}
