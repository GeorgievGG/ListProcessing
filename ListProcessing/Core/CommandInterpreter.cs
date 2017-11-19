namespace ListProcessing.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using ListProcessing.Contracts;
    using ListProcessing.Infrastructure.Constants;

    public class CommandInterpreter
    {
        private readonly CommandFactory commandFactory;

        public CommandInterpreter(CommandFactory commandFactory)
        {
            //this.commandFactory = ???
        }

        public string Process(List<string> inputList)
        {
            string command = inputList[0];
            var parameters = inputList.Skip(1);

            if (!CommandConstants.CommandsList.ContainsKey(command))
            {
                throw new ArgumentException("Error: invalid command");
            }

            if (CommandConstants.CommandsList[command].Count() != parameters.Count())
            {
                throw new ArgumentException("Error: invalid command parameters");
            }

           //...

            
        }
    }
}
