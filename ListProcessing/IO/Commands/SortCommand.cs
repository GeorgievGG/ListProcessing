namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    //Test - to be updated
    public class SortCommand : Command
    {
        private readonly int inputIndex;
        private readonly string inputString;

        public SortCommand(ListProcessingManager manager, int inputIndex, string inputString) : base(manager)
        {
            this.inputIndex = inputIndex;
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Sort();
        }
    }
}
