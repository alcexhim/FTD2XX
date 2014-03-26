using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTD2XX
{
    public class DeviceNotFoundException : InvalidOperationException
    {
    }
    
    [Flags()]
    public enum DeviceOpenPurpose
    {
        None = 0,
        Erase = 1,
        Write = 2,
        Any = 3
    }

    public class DeviceNotOpenedException : InvalidOperationException
    {
        private DeviceOpenPurpose mvarPurpose = DeviceOpenPurpose.Any;
        public DeviceOpenPurpose Purpose { get { return mvarPurpose; } }

        public DeviceNotOpenedException(DeviceOpenPurpose purpose = DeviceOpenPurpose.Any)
        {
            mvarPurpose = purpose;
        }
    }

    [Flags()]
    public enum DeviceOperation
    {
        None = 0,
        Erase = 1,
        Read = 2,
        Write = 4
    }
    public class EEPROMOperationFailedException : System.IO.IOException
    {
        private DeviceOperation mvarOperation = DeviceOperation.None;
        public DeviceOperation Operation { get { return mvarOperation; } }

        public EEPROMOperationFailedException(DeviceOperation operation)
        {
            mvarOperation = operation;
        }
    }
    public class EEPROMNotPresentException : System.IO.IOException
    {
    }
    public class EEPROMNotProgrammedException : System.IO.IOException
    {
    }
    public class DeviceOperationFailedException : System.IO.IOException
    {
        private DeviceOperation mvarOperation = DeviceOperation.None;
        public DeviceOperation Operation { get { return mvarOperation; } }

        public DeviceOperationFailedException(DeviceOperation operation)
        {
            mvarOperation = operation;
        }
    }
}
