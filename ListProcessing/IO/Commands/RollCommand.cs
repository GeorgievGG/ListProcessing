namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    public class RollCommand : Command
    {
        private readonly string inputString;

        public RollCommand(ListProcessingManager manager, string inputString) : base(manager)
        {
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Roll(inputString);
        }
    }
}
