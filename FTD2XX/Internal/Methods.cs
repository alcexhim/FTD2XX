using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX.Internal
{
    internal static class Methods
    {
    	public static void ftdi_status_to_exception(Internal.Constants.FT_STATUS status)
        {
            switch (status)
            {
                case Internal.Constants.FT_STATUS.DeviceNotFound:
                {
                    throw new DeviceNotFoundException();
                }
                case Internal.Constants.FT_STATUS.DeviceNotOpened:
                {
                    throw new DeviceNotOpenedException();
                }
                case Internal.Constants.FT_STATUS.DeviceNotOpenedForErase:
                {
                    throw new DeviceNotOpenedException(DeviceOpenPurpose.Erase);
                }
                case Internal.Constants.FT_STATUS.DeviceNotOpenedForWrite:
                {
                    throw new DeviceNotOpenedException(DeviceOpenPurpose.Write);
                }
                case Internal.Constants.FT_STATUS.EEPROMEraseFailed:
                {
                    throw new EEPROMOperationFailedException(DeviceOperation.Erase);
                }
                case Internal.Constants.FT_STATUS.EEPROMNotPresent:
                {
                    throw new EEPROMNotPresentException();
                }
                case Internal.Constants.FT_STATUS.EEPROMNotProgrammed:
                {
                    throw new EEPROMNotProgrammedException();
                }
                case Internal.Constants.FT_STATUS.EEPROMReadFailed:
                {
                    throw new EEPROMOperationFailedException(DeviceOperation.Read);
                }
                case Internal.Constants.FT_STATUS.EEPROMWriteFailed:
                {
                    throw new EEPROMOperationFailedException(DeviceOperation.Write);
                }
                case Internal.Constants.FT_STATUS.FailedToWriteDevice:
                {
                    throw new DeviceOperationFailedException(DeviceOperation.Erase);
                }
                case Internal.Constants.FT_STATUS.InsufficientResources:
                {
                    throw new InsufficientMemoryException();
                }
                case Internal.Constants.FT_STATUS.InvalidArguments:
                {
                    throw new ArgumentException();
                }
                case Internal.Constants.FT_STATUS.InvalidBaudRate:
                {
                    throw new ArgumentException("The baud rate is invalid", "BaudRate");
                }
                case Internal.Constants.FT_STATUS.InvalidHandle:
                {
                    throw new ArgumentException("The handle is invalid", "Handle");
                }
                case Internal.Constants.FT_STATUS.InvalidParameter:
                {
                    throw new ArgumentException("The parameter is invalid");
                }
                case Internal.Constants.FT_STATUS.IOError:
                {
                    throw new System.IO.IOException();
                }
                case Internal.Constants.FT_STATUS.UnknownError:
                {
                    throw new Exception("Unknown error occurred");
                }
            }
        }

		internal static Constants.FT_STATUS ftdi_set_line_property2(ref Internal.Structures.ftdi_context /*struct ftdi_context*/ ftdi, BitsPerWord bits, StopBits stopBits, Parity parity, bool break_on)
		{
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
					return Linux.Methods.ftdi_set_line_property2(ref ftdi, bits, stopBits, parity, break_on);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
		}

		internal static Constants.FT_STATUS ftdi_set_line_property(ref Internal.Structures.ftdi_context  /*struct ftdi_context*/ ftdi, BitsPerWord bits, StopBits stopBits, Parity parity)
		{
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
					return Linux.Methods.ftdi_set_line_property(ref ftdi, bits, stopBits, parity);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
		}

		public static Constants.FT_STATUS ftdi_set_baudrate(ref Internal.Structures.ftdi_context  /*struct ftdi_context*/ ftdi, int baudRate)
		{
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
					return Linux.Methods.ftdi_set_baudrate(ref ftdi, baudRate);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
		}

		internal static Constants.FT_STATUS ftdi_usb_reset(ref Internal.Structures.ftdi_context /*struct ftdi_context*/ ftdi)
		{
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
					return Linux.Methods.ftdi_usb_reset(ref ftdi);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
		}

		public static Constants.FT_STATUS ftdi_usb_open(ref Internal.Structures.ftdi_context ftdi, int vendor, int product)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
					return Linux.Methods.ftdi_usb_open(ref ftdi, vendor, product);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }

		public static Constants.FT_STATUS ftdi_init(ref Internal.Structures.ftdi_context ftdi)
		{
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.ftdi_init(ref ftdi);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
		}

		public static Constants.FT_STATUS ftdi_usb_close(ref Internal.Structures.ftdi_context /*struct ftdi_context*/ ftdi)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.ftdi_usb_close(ref ftdi);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					throw new PlatformNotSupportedException();
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static Constants.FT_STATUS ftdi_read_data(ref Internal.Structures.ftdi_context /*struct ftdi_context*/ ftdi, IntPtr buf, int size)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.ftdi_read_data(ref ftdi, buf, size);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
        public static int ftdi_write_data(ref Internal.Structures.ftdi_context  /*struct ftdi_context*/ ftdi, IntPtr buf, int size)
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                {
                    break;
                }
                case PlatformID.Unix:
                {
                    return Linux.Methods.ftdi_write_data(ref ftdi, buf, size);
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                {
					break;
                }
                case PlatformID.Xbox:
                {
                    break;
                }
            }
            throw new PlatformNotSupportedException();
        }
		/*
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
        */
    }
}
