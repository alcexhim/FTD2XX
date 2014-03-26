using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX
{
    [Flags()]
    public enum PurgeBuffer : uint
    {
        None = 0,
        RX = 1,
        TX = 2,
        Both = RX | TX
    }
}
