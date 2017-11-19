namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class ReverseCommand : Command
    {
        public ReverseCommand(ListProcessingManager manager) : base(manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.Reverse();
        }
    }
}
