using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestFramework.Log
{
    public interface ILogger
    {
        // local directory where the log files and images are stored
        string Directory { get; }

        // remote directory where the log files and images are stored
        string DirectoryRemote { get; }

        //current test log file
        string File { get; }

        //current test log file in windows share format
        string FileRemote { get; }

        List<string> FailMsgs { get; set; }

        LogConfiguration LogConfiguration { get; set; }

        void Debug(string text);

        void DebugError(string text);

        void DebugAction(string finder, string action);

        void Message(string text);

        void Fail(string text);

        void Step(string text);

        void Warn(string text);
        void Action(string finder, string action);

        void SnapShotAndUrl(string imagePath, string url);

        void Remove();

    }
}
