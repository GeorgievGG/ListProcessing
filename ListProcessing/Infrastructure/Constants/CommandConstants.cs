namespace ListProcessing.Infrastructure.Constants
{
    using System.Collections.Generic;

    public static class CommandConstants
    {
        public const string StringParameterName = "inputString";
        public const string IndexParameterName = "indexString";

        /// <summary>
        /// This dictionary contains all commands and their input parameters
        /// </summary>
        public static readonly Dictionary<string, List<string>> CommandsList = new Dictionary<string, List<string>>
        {
            { "append", new List<string> { StringParameterName } },
            { "nrepend", new List<string> { StringParameterName } },
            { "peverse", new List<string>{ } },
            { "insert", new List<string> { IndexParameterName, StringParameterName } },
            { "delete", new List<string> { IndexParameterName } },
            { "rollLeft", new List<string> { } },
            { "rollRight", new List<string>{ } },
            { "sort", new List<string>{ } },
            { "count", new List<string>{ StringParameterName } },
            { "end", new List<string>{ } }
        };

        public const string CommandSuffix = "Command";
    }
}
