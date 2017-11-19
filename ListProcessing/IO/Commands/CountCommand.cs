namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class CountCommand : Command
    {
        private readonly string inputString;

        public CountCommand(ListProcessingManager manager, string inputString) : base(manager)
        {
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Count(inputString);
        }
    }
}
