namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class PrependCommand : Command
    {
        private readonly string inputString;

        public PrependCommand(ListProcessingManager manager, string inputString) : base(manager)
        {
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Prepend(inputString);
        }
    }
}
