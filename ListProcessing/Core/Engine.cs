namespace ListProcessing.Core
{
    using ListProcessing.Infrastructure.Constants;
    using System;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            var input = string.Empty;
            var initialValues = Console.ReadLine().Split().ToList();
            ListProcessingManager.Initialize(initialValues);
            var commandFactory = new CommandFactory();
            var commandInterpreter = new CommandInterpreter(commandFactory);
            while ((input = Console.ReadLine()) != CommandConstants.ProgramTerminatingCommand)
            {
                try
                {
                    var inputParams = input.Split().ToList();
                    commandInterpreter.Process(inputParams);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(CommandConstants.ProgramTerminationConfirmation);
        }
    }
}
