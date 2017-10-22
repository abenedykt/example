using Food.Abstract;

namespace Food.Commands
{
    internal class CommandExecutor
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}