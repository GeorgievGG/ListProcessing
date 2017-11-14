using ListProcessing.Contracts;
using System;

namespace ListProcessing.IO.Commands
{
    public abstract class Command : ICommand
    {
        private string[] data;

        protected Command(string[] data)
        {
            this.Data = data;
        }

        public string[] Data
        {
            get
            {
                return this.data;
            }

            protected set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }

                this.data = value;
            }
        }

        public abstract string Execute();
    }
}
