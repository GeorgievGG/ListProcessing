﻿namespace ListProcessing.Core
{
    using ListProcessing.Infrastructure.Constants;
    using System.Collections.Generic;
    using System.Linq;

    public class ListProcessingManager
    {
        private static IList<string> list;

        public static string Initialize(IList<string> inputList)
        {
            list = inputList;

            return string.Join(OutputConstants.OutputStringSeparator, list);
        }

        public string Append(string stringToAppend)
        {
            list.Add(stringToAppend);
           return string.Join(OutputConstants.OutputStringSeparator, list);
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
            if (list.ElementAtOrDefault(index) != null)
            {
                list.RemoveAt(index);
                return string.Join(OutputConstants.OutputStringSeparator, list);
            }
            else
            {
                return string.Format(ErrorConstants.InvalidIndex, index);
            }
          
        }

        public string End()
        {
            return CommandConstants.ProgramTerminationConfirmation;
        }

        public string Insert(int index, string stringToInsert)
        {
            if (list.ElementAtOrDefault(index) != null)
            {
                list.Insert(index, stringToInsert);
                return string.Join(OutputConstants.OutputStringSeparator, list);
            }
            else
            {
                return string.Format(ErrorConstants.InvalidIndex, index);
            }
           
        }

        public string Prepend(string stringToPrepend)
        {
            list.Insert(0, stringToPrepend);
           return string.Join(OutputConstants.OutputStringSeparator, list);
        }

        public string Reverse()
        {
            list = list.Reverse().ToList();
            return string.Join(OutputConstants.OutputStringSeparator, list);
        }

        public string Sort()
        {
            list = list.OrderBy(w => w).ToList();
            return string.Join(OutputConstants.OutputStringSeparator, list);
        }

        public string Roll(string direction)
        {
            if (direction=="left")
            {
                string first = list[0];
                list.RemoveAt(0);
                list.Add(first);
                return string.Join(OutputConstants.OutputStringSeparator, list);
            }
            else if (direction=="right")
            {
                string last = list.Last();
                list.RemoveAt(list.Count - 1);
                list.Insert(0, last);
                return string.Join(OutputConstants.OutputStringSeparator, list);
            }

            else
            {
                return ErrorConstants.InvalidCommandParameters;
            }
           
        }      
    }
}
