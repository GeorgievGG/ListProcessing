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
            while ((input = Console.ReadLine()) != CommandConstants.ProgramTerminatingCommand)
            {
                try
                {
                    var inputParams = input.Split();
                    //var commandInterpreter = new CommandInterpreter(new CommandFactory(), inputParams);
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
