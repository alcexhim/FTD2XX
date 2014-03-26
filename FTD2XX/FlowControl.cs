using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX
{
    public enum FlowControl : ushort
    {
        None = 0x000,
        RTSCTS = 0x100,
        DTRDSR = 0x200,
        XonXoff = 0x400
    }
}
