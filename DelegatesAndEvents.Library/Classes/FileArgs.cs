using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Library.Classes
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; }

        public FileArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
