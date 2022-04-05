using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YoutubeExplode
{
    abstract public class Command
    {
        public abstract Task RunInfo();
        public abstract Task RunDownload();
    }
}
