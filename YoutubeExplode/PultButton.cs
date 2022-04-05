using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExplode
{
    public class PultButton //Отправитель команды
    {
        Command _command;
        public void ChangeCommand(Command command)
        {
            _command = command;
        }
        public void InfoVideo()
        {
            _command.RunInfo();
        }
        public void DownLoadVideo()
        {
            _command.RunDownload();
        }

    }
}
