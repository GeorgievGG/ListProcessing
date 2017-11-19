namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    public class InsertCommand : Command
    {
        private readonly string inputString;

        private readonly int inputIndex;

        public InsertCommand(ListProcessingManager manager, string inputString, int inputIndex) : base(manager)
        {
            this.inputString = inputString;
            this.inputIndex = inputIndex;
        }

        public override string Execute()
        {
            return this.Manager.Insert(inputIndex, inputString);
        }
    }
}
