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

        public ICommand Create(string command, Dictionary<string, string> parameters)
        {
            Type commandType = commandTypes[command];
            ConstructorInfo ctor = commandType.GetConstructors().FirstOrDefault();
            ParameterInfo[] ctorParameters = ctor.GetParameters();

            List<object> ctorParamValues = new List<object>();

            foreach (ParameterInfo parameter in ctorParameters)
            {
                string name = parameter.Name;
                Type type = parameter.ParameterType;

                if (type.IsPrimitive || type == typeof(string))
                {
                    if (parameters.ContainsKey(name))
                    {
                        ctorParamValues.Add(Convert.ChangeType(parameters[name], type));
                    }
                }
                else
                {
                    if (type.IsInterface)
                    {

                    }

                    ctorParamValues.Add(Activator.CreateInstance(type));
                }
            }

            return (ICommand)ctor.Invoke(ctorParamValues.ToArray());
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
