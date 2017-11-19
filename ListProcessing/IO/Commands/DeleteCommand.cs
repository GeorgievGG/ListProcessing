namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;
    
    public class DeleteCommand : Command
    {
        private readonly int inputIndex;

        public DeleteCommand(ListProcessingManager manager, int inputIndex) : base(manager)
        {
            this.inputIndex = inputIndex;
        }

        public override string Execute()
        {
            return this.Manager.Delete(inputIndex);
        }
    }
}
