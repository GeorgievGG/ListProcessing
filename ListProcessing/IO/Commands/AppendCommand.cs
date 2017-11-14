namespace ListProcessing.IO.Commands
{
    using ListProcessing.Contracts;

    //Test - to be updated
    public class AppendCommand : ICommand
    {
        private readonly int index;
        private readonly string inputString;
        private readonly IListProcessingManager manager;

        public AppendCommand(IListProcessingManager manager, int index, string inputString)
        {
            this.manager = manager;
            this.index = index;
            this.inputString = inputString;
        }

        public string Execute()
        {
            return this.index + " " + this.inputString;
        }
    }
}
