namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class SortCommand : Command
    {
        public SortCommand(ListProcessingManager manager) : base(manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.Sort();
        }
    }
}
