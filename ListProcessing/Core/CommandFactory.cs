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

        /// <summary>
        /// Creates an instance of a class implementing ICommand interface
        /// </summary>
        /// <param name="command">Name of the command w/o suffix 'Command'</param>
        /// <param name="parameters">Dictionary with all input parameters of primitive type with their values (key=paramName, value=paramValue)</param>
        /// <returns></returns>
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
                    Type interfaceType = null;

                    if (type.IsInterface)
                    {
                        interfaceType = type;

                        type = Assembly.GetExecutingAssembly().GetTypes().Where(t => type.IsAssignableFrom(t) && !t.IsInterface).FirstOrDefault();
                    }

                    if (type == null)
                    {
                        throw new InvalidOperationException($"Please provide implementation for interface {interfaceType.Name}");
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
