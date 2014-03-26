using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX.Internal
{
    internal static class Constants
    {
        /// <summary>
        /// Return statuses for FTD2XX functions.
        /// </summary>
        public enum FT_STATUS
        {
            None = 0,
            InvalidHandle,
            DeviceNotFound,
            DeviceNotOpened,
            IOError,
            InsufficientResources,
            InvalidParameter,
            InvalidBaudRate,
            DeviceNotOpenedForErase,
            DeviceNotOpenedForWrite,
            FailedToWriteDevice,
            EEPROMReadFailed,
            EEPROMWriteFailed,
            EEPROMEraseFailed,
            EEPROMNotPresent,
            EEPROMNotProgrammed,
            InvalidArguments,
            UnknownError
        };

        public enum FT_LISTDEVICES : uint
        {
            None = 0x00000000,
            OpenBySerialNumber = 0x00000001,
            OpenByDescription = 0x00000002,
            ListAll = 0x20000000,
            ListByIndex = 0x40000000,
            ListNumberOnly = 0x80000000
        }
    }
}
