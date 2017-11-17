namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            //Test - to be removed later
            Console.WriteLine(new CommandFactory()
                .Create("append", new Dictionary<string, string>(){ { "inputIndex", "2" }, {"inputString", "test" } })
                .Execute());
        }
    }
}
