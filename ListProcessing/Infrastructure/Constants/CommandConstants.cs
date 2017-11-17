using System.Collections.Generic;

namespace ListProcessing.Infrastructure.Constants
{
    public static class CommandConstants
    {
        public static readonly Dictionary<string, List<string>> CommandsList = new Dictionary<string, List<string>>
        {
            { "append", new List<string> { "inputString"} },
            { "insert", new List<string> { "inputIndex", "inputString" } },
            { "delete", new List<string> { "inputIndex" } }
        };

        public const string CommandSuffix = "Command";
    }
}
