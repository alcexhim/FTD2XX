using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FTD2XX.Internal.Windows
{
    internal static class Methods
    {
        private const string LIBRARY_FILENAME = "FTD2XX.dll";

        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_Open(UInt32 uiPort, ref uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_Close(uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_Read(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesReturned);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_Write(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesWritten);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_SetDataCharacteristics(uint ftHandle, BitsPerWord uWordLength, StopBits uStopBits, Parity uParity);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_SetFlowControl(uint ftHandle, FlowControl usFlowControl, byte uXon, byte uXoff);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_GetModemStatus(uint ftHandle, ref UInt32 lpdwModemStatus);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_Purge(uint ftHandle, PurgeBuffer dwMask);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_ClrRts(uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_SetBreakOn(uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_SetBreakOff(uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_GetStatus(uint ftHandle, ref UInt32 lpdwAmountInRxQueue, ref UInt32 lpdwAmountInTxQueue, ref UInt32 lpdwEventStatus);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_ResetDevice(uint ftHandle);
        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_SetDivisor(uint ftHandle, char usDivisor);

        [DllImport(LIBRARY_FILENAME)]
        public static extern Constants.FT_STATUS FT_ListDevices(ref int numDevs, IntPtr doNotUse, Internal.Constants.FT_LISTDEVICES flags);
    }
}
