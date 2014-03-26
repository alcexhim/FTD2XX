using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FTD2XX
{
    // [DebuggerNonUserCode()]
    public class Device
    {
        private uint mvarHandle = 0;
        public uint Handle { get { return mvarHandle; } }
        
        private uint mvarPort = 0;
        public uint Port { get { return mvarPort; } }

        public Device(uint port)
        {
            mvarPort = port;
        }

        public void Open()
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_Open(mvarPort, ref mvarHandle);
        }

        private bool mvarBreak = false;
        public bool Break
        {
            get { return mvarBreak; }
            set
            {
                mvarBreak = value;
                switch (value)
                {
                    case true:
                    {
                        Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetBreakOn(mvarHandle);
                        FT_StatusToException(status);
                        break;
                    }
                    case false:
                    {
                        Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetBreakOff(mvarHandle);
                        FT_StatusToException(status);
                        break;
                    }
                }
            }
        }

        private static void FT_StatusToException(Internal.Constants.FT_STATUS status)
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

        private byte[] mvarBuffer = new byte[0];

        private bool mvarAutoFlush = true;
        public bool AutoFlush { get { return mvarAutoFlush; } set { mvarAutoFlush = value; } }

        public void Reset()
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_ResetDevice(mvarHandle);
            FT_StatusToException(status);
        }

        public int Write(byte[] buffer)
        {
            int start = mvarBuffer.Length;
            Array.Resize<byte>(ref mvarBuffer, mvarBuffer.Length + buffer.Length);
            Array.Copy(buffer, 0, mvarBuffer, start, buffer.Length);
            if (mvarAutoFlush) return Flush();
            return 0;
        }
        public int Flush()
        {
            IntPtr ptr = Marshal.AllocHGlobal((int)mvarBuffer.Length);
            Marshal.Copy(mvarBuffer, 0, ptr, (int)mvarBuffer.Length);
            uint bytesWritten = 0;

            Internal.Constants.FT_STATUS status = Internal.Methods.FT_Write(mvarHandle, ptr, (uint)mvarBuffer.Length, ref bytesWritten);
            FT_StatusToException(status);

            mvarBuffer = new byte[0];
            return (int)bytesWritten;
        }

        public void SetBaudRate(int baudRate)
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetDivisor(mvarHandle, (char)baudRate);  // set baud rate
            FT_StatusToException(status);
        }

        public void SetDataCharacteristics(BitsPerWord bits, StopBits stopBits, Parity parity)
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetDataCharacteristics(mvarHandle, bits, stopBits, parity);
            FT_StatusToException(status);
        }
        public void SetFlowControl(FlowControl control, byte uXon, byte uXoff)
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetFlowControl(mvarHandle, control, uXon, uXoff);
            FT_StatusToException(status);
        }
        public void ClearRTS()
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_ClrRts(mvarHandle);
            FT_StatusToException(status);
        }
        public void Purge(PurgeBuffer buffers = PurgeBuffer.Both)
        {
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_Purge(mvarHandle, buffers);
            FT_StatusToException(status);
        }

        public static int GetDeviceCount()
        {
            int numDevs = 0;
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_ListDevices(ref numDevs, IntPtr.Zero, Internal.Constants.FT_LISTDEVICES.ListNumberOnly);
            FT_StatusToException(status);
            return numDevs;
        }
        public static Device[] GetDevices()
        {
            List<Device> devices = new List<Device>();
            int count = GetDeviceCount();
            for (uint i = 0; i < count; i++)
            {
                Device device = new Device(i);
                devices.Add(device);
            }
            return devices.ToArray();
        }

        /// <summary>
        /// Closes the handle to this FTD2XX device.
        /// </summary>
        public void Close()
        {
            Internal.Methods.FT_Close(mvarHandle);
        }
    }
}
