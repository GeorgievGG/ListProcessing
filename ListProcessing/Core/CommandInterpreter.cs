namespace ListProcessing.Core
{
    using Infrastructure.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        private readonly CommandFactory commandFactory;

        public CommandInterpreter(CommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public string Process(IList<string> inputList)
        {
            string command = inputList[0];
            var parameters = inputList.Skip(1).ToList();

            if (!CommandConstants.CommandsList.ContainsKey(command))
            {
                throw new ArgumentException(ErrorConstants.InvalidCommand);
            }

            if (CommandConstants.CommandsList[command].Count() != parameters.Count())
            {
                throw new ArgumentException(ErrorConstants.InvalidCommandParameters);
            }

            Dictionary<string, string> commandParams = new Dictionary<string, string>();

            for (int i = 0; i < CommandConstants.CommandsList[command].Count; i++)
            {
                commandParams.Add(CommandConstants.CommandsList[command][i], parameters[i]);
            }

            return this.commandFactory
                .Create(command, commandParams)
                .Execute();
        }
    }
}
