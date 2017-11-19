namespace ListProcessing.Core
{
    using ListProcessing.Infrastructure.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            string input = string.Empty;

            IList<string> initialValues = Console.ReadLine().Split().ToList();

            Console.WriteLine(ListProcessingManager.Initialize(initialValues));

            CommandFactory commandFactory = new CommandFactory();

            CommandInterpreter commandInterpreter = new CommandInterpreter(commandFactory);

            

            while (true)
            {
                input = Console.ReadLine();

                try
                {
                    IList<string> inputParams = input.Split().ToList();

                    string result = commandInterpreter.Process(inputParams);

                    Console.WriteLine(result);

                    if (result == CommandConstants.ProgramTerminationConfirmation)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
