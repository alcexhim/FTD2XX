using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX.Internal
{
    internal static class Methods
    {
        public static Constants.FT_STATUS FT_Open(UInt32 uiPort, ref uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_Open(uiPort, ref ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_Open(uiPort, ref ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_Close(uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_Close(ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_Close(ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_Read(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesReturned)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_Read(ftHandle, lpBuffer, dwBytesToRead, ref lpdwBytesReturned);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_Read(ftHandle, lpBuffer, dwBytesToRead, ref lpdwBytesReturned);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_Write(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesWritten)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_Write(ftHandle, lpBuffer, dwBytesToRead, ref lpdwBytesWritten);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_Write(ftHandle, lpBuffer, dwBytesToRead, ref lpdwBytesWritten);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_SetDataCharacteristics(uint ftHandle, BitsPerWord uWordLength, StopBits uStopBits, Parity uParity)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_SetDataCharacteristics(ftHandle, uWordLength, uStopBits, uParity);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_SetDataCharacteristics(ftHandle, uWordLength, uStopBits, uParity);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_SetFlowControl(uint ftHandle, FlowControl usFlowControl, byte uXon, byte uXoff)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_SetFlowControl(ftHandle, usFlowControl, uXon, uXoff);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_SetFlowControl(ftHandle, usFlowControl, uXon, uXoff);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_GetModemStatus(uint ftHandle, ref UInt32 lpdwModemStatus)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_GetModemStatus(ftHandle, ref lpdwModemStatus);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_GetModemStatus(ftHandle, ref lpdwModemStatus);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_Purge(uint ftHandle, PurgeBuffer dwMask)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_Purge(ftHandle, dwMask);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_Purge(ftHandle, dwMask);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_ClrRts(uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_ClrRts(ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_ClrRts(ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_SetBreakOn(uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_SetBreakOn(ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_SetBreakOn(ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_SetBreakOff(uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_SetBreakOff(ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_SetBreakOff(ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_GetStatus(uint ftHandle, ref UInt32 lpdwAmountInRxQueue, ref UInt32 lpdwAmountInTxQueue, ref UInt32 lpdwEventStatus)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_GetStatus(ftHandle, ref lpdwAmountInRxQueue, ref lpdwAmountInTxQueue, ref lpdwEventStatus);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_GetStatus(ftHandle, ref lpdwAmountInRxQueue, ref lpdwAmountInTxQueue, ref lpdwEventStatus);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_ResetDevice(uint ftHandle)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_ResetDevice(ftHandle);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_ResetDevice(ftHandle);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_SetDivisor(uint ftHandle, char usDivisor)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_SetDivisor(ftHandle, usDivisor);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_SetDivisor(ftHandle, usDivisor);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS FT_ListDevices(ref int numDevs, IntPtr doNotUse, Internal.Constants.FT_LISTDEVICES flags)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.FT_ListDevices(ref numDevs, doNotUse, flags);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
                    return Windows.Methods.FT_ListDevices(ref numDevs, doNotUse, flags);
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
    }
}
