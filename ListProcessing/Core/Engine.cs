namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }

            Console.WriteLine(new CommandFactory()
                .Create("append", new Dictionary<string, string>() { { "inputIndex", "2" }, { "inputString", "test" } })
                .Execute());
        }
    }
}
