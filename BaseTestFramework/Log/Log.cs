using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestFramework.Log
{
    public class Log
    {

        private readonly List<ILogger> _actualLoggers = new List<ILogger>();

        public IReadOnlyList<ILogger> ActualLoggers => _actualLoggers;

        public bool VerboseLogging
        {
            get { return }
        }

    }
}
