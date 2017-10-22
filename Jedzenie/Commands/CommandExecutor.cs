using System;
using Food.Abstract;

namespace Food.Commands
{
    internal class CommandExecutor
    {
        public void Execute(ICommand command)
        {
            Console.WriteLine($"executing command {command.GetType().Name}");

            try
            {
                command.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception in {command.GetType().Name}");
                Console.WriteLine(e);
            }
        }
    }
}