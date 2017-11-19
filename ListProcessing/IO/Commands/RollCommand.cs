namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    public class RollCommand : Command
    {
        private readonly string direction;

        public RollCommand(ListProcessingManager manager, string direction) : base(manager)
        {
            this.direction = direction;
        }

        public override string Execute()
        {
            return this.Manager.Roll(direction);
        }
    }
}
