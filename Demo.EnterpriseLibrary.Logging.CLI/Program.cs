using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EnterpriseLibrary.Logging.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            logger.LogInformation("Information message");
            logger.LogWarning("Warning message");
            logger.LogError("Error message");
            logger.LogVerbose("Verbose message");

            logger.LogDebug("Debug message");
        }
    }
}
