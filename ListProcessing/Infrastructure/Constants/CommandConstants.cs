namespace ListProcessing.Infrastructure.Constants
{
    using System.Collections.Generic;

    public static class CommandConstants
    {
        public const string StringParameterName = "inputString";

        public const string IndexParameterName = "inputIndex";

        public const string DirectionParameterName = "direction";

        public const string ProgramTerminatingCommand = "end";

        public const string ProgramTerminationConfirmation = "Finished";

        /// <summary>
        /// This dictionary contains all commands and their input parameters
        /// </summary>
        public static readonly Dictionary<string, List<string>> CommandsList = new Dictionary<string, List<string>>
        {
            { "append", new List<string> { StringParameterName } },
            { "prepend", new List<string> { StringParameterName } },
            { "reverse", new List<string>{ } },
            { "insert", new List<string> { IndexParameterName, StringParameterName } },
            { "delete", new List<string> { IndexParameterName } },
            { "end", new List<string>{ } },
            { "roll", new List<string> { DirectionParameterName } },
            { "sort", new List<string>{ } },
            { "count", new List<string>{ StringParameterName } }
        };

        public const string CommandSuffix = "Command";
    }
}
