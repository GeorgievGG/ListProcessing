namespace ListProcessing.Core
{
    using System;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            var input = string.Empty;
            var initialValues = Console.ReadLine().Split().ToList();
            ListProcessingManager.Initialize(initialValues);
            while ((input = Console.ReadLine()) != "end")
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
        }
    }
}
