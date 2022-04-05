using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YoutubeExplode
{
    class Sender
    {
        Command? _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }
        public void Run()
        {
            _command.Run();
        }
    }
}
