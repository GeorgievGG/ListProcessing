using System;
using System.Collections.Generic;

namespace ListProcessing.Core
{
    public class Engine
    {
        public void Run()
        {
            //Test - to be removed later
            Console.WriteLine(new CommandFactory()
                .Create("append", new Dictionary<string, string>(){ {"index", "2" }, {"inputString", "test" } })
                .Execute());
        }
    }
}
