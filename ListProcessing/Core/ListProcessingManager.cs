namespace ListProcessing.Core
{
    using System.Collections.Generic;
    using System.Linq;

    public class ListProcessingManager
    {
        private static IList<string> list;

        public static string Initialize(IList<string> inputList)
        {
            list = inputList;

            return string.Join(" ", list);
        }

        //TO DO: all commands as instance methods...

        public string Append(string stringToAppend)
        {
            list.Add(stringToAppend);
           return string.Join(" ", list);
        }

        public string Count(string searchWord)
        {
           
            int counter = 0;

            foreach (var word in list)
            {
                if (word == searchWord)
                {
                    counter++;
                }
            }
            return counter.ToString();
        }

        public string Delete(int index)
        {
            list.RemoveAt(index);
            return string.Join(" ",list);
        }

        public string End()
        {
            return "Finished";
        }

        public string Insert(int index, string stringToInsert)
        {
            list.Insert(index, stringToInsert);
            return string.Join(" ", list);
        }

        public string Prepend(string stringToPrepend)
        {
            list.Insert(0, stringToPrepend);
           return string.Join(" ", list);
        }

        public string Reverse()
        {
            list.Reverse();
            return string.Join(" ", list);
        }

        public string Sort()
        {
            list.OrderBy(w => w);
            return string.Join(" ", list);
        }

        public string RollLeft()
        {
            string first = list[0];
            list.RemoveAt(0);
            list.Add(first);
           return string.Join(" ", list);
        }

        public string RollRight()
        {
            string last = list.Last();
            list.RemoveAt(list.Count - 1);
            list.Insert(0, last);
            return string.Join(" ", list);
        }
    }
}
