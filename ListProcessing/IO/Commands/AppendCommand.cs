namespace ListProcessing.IO.Commands
{
    using ListProcessing.Core;

    //Test - to be updated
    public class AppendCommand : Command
    {
        private readonly int index;
        private readonly string inputString;

        public AppendCommand(ListProcessingManager manager, int index, string inputString) : base(manager)
        {
            this.index = index;
            this.inputString = inputString;
        }

        public override string Execute()
        {
            return this.index + " " + this.inputString;
        }
    }
}
