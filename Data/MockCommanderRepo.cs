using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
    public class MockCommanderRepo : ICommanderRepo 
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command(0, "do it", "command text", "linux"),
                new Command(1, "not that", "different command", "linux"),
                new Command(2, "more", "code here", "Mac")
            };

            /*
                new Command(Id=0, HowTo="do it", Line="command text", Platform="linux"),
                new Command(Id=0, HowTo="not that", Line="different command", Platform="linux"),
                new Command(Id=0, HowTo="more", Line="code here", Platform="Mac")
            */
            
            return commands;
        }

        public Command GetCommandById(int id) 
        {
            // return new Command(Id=0, HowTo="do it", Line="command text", Platform="linux");
            return new Command(10, "do it", "command text", "linux");
        }
    }
}