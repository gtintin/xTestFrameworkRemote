using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestFramework.Log
{
    public class LogConfiguration
    {
        public LogConfiguration()
        {

        }

        public bool VerboseLogging { get; set; }
        public string RootDirectory { get; set; }
        public bool OpenSummary { get; set; }
        public bool DisableLogging { get; set; }
        public bool DisableSnapShots { get; set; }


    }


}
