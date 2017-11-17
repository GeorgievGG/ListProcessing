namespace ListProcessing.Core
{
    using System.Collections.Generic;

    public class ListProcessingManager
    {
        private static IList<string> list;

        public static string Initialize(IList<string> inputList)
        {
            list = inputList;

            return string.Join(" ", list);
        }

        //TO DO: all commands as instance methods...
    }
}
