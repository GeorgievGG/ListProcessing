namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    //Test - to be updated
    public class PrependCommand : Command
    {
        private readonly int inputIndex;
        private readonly string inputString;

        public PrependCommand(ListProcessingManager manager, int inputIndex, string inputString) : base(manager)
        {
            this.inputIndex = inputIndex;
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.Manager.Prepend(inputString);
        }
    }
}
