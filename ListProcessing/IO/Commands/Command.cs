﻿namespace ListProcessing.IO.Commands
{
    using ListProcessing.Contracts;
    using ListProcessing.Core;

    public abstract class Command : ICommand
    {
        private readonly ListProcessingManager manager;

        protected Command(ListProcessingManager manager)
        {
            this.manager = manager;
        }

        protected ListProcessingManager Manager => manager;

        public abstract string Execute();
    }
}
