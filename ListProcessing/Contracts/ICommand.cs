namespace ListProcessing.Contracts
{
    public interface ICommand
    {
        string[] Data { get; set; }

        string Execute();
    }
}
