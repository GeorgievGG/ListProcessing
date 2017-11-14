namespace ListProcessing.Core
{
    using Contracts;
    using Infrastructure.Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class CommandFactory
    {
        private static readonly IDictionary<string, Type> commandTypes;

        static CommandFactory()
        {
            commandTypes = new Dictionary<string, Type>();

            Initializer();
        }

        ICommand Create(string command)
        {


            return null;
        }

        private static void Initializer()
        {
            IEnumerable<Type> types =
                Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ICommand).IsAssignableFrom(t) && !t.IsInterface)
                .ToList();

            foreach (Type type in types)
            {
                commandTypes
                    .Add(type.Name.Replace(CommandConstants.CommandSuffix, string.Empty)
                    .ToLower(), type);
            }
        }
    }
}
