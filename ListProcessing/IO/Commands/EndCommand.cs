namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    public class EndCommand : Command
    {
        public EndCommand(ListProcessingManager manager) : base(manager)
        {
            
        }

        public override string Execute()
        {
            return this.Manager.End();
        }
    }
}
