using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFilesLib
{
    public class Program
    {
        IDirectoryExplorer _directoryExplorer;

        public Program() { }

        public Program(IDirectoryExplorer _directoryExplorer)
        {
            this._directoryExplorer = _directoryExplorer;
        }

        public ICollection<string> GetAllFiles(string path)
        {
            ICollection<string> files = _directoryExplorer.GetFiles(path);
            return files;
        }
    }
}
