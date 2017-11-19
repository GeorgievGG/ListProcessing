namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class AppendCommand : Command
    {
        private readonly string inputString;

        public AppendCommand(ListProcessingManager manager, string inputString) : base(manager)
        {
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Append(inputString);
        }
    }
}
