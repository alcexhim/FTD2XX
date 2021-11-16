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
		private static Internal.Structures.ftdi_context _H = new Internal.Structures.ftdi_context();
		static Device()
		{
			Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_init(ref _H);
			Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}

		private string _Desc = null;

		public int VendorID { get; set; } = 0x0;
		public int ProductID { get; set; } = 0x0;

		public Device(string desc)
		{
			_Desc = desc;
		}
		public Device(int vendorID, int productID)
        {
			VendorID = vendorID;
			ProductID = productID;
        }

        public void Open()
        {
			if (_Desc != null)
			{
				Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_usb_open_string(ref _H, _Desc);
				Internal.Methods.ftdi_status_to_exception(status, ref _H);
			}
			else
			{
				Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_usb_open(ref _H, VendorID, ProductID);
				Internal.Methods.ftdi_status_to_exception(status, ref _H);
			}
		}

		private byte[] mvarBuffer = new byte[0];

		public bool AutoFlush { get; set; } = true;

		public int Write(byte[] buffer)
		{
			int start = mvarBuffer.Length;
			Array.Resize<byte>(ref mvarBuffer, mvarBuffer.Length + buffer.Length);
			Array.Copy(buffer, 0, mvarBuffer, start, buffer.Length);
			if (AutoFlush) return Flush();
			return 0;
		}
		public int Flush()
		{
			IntPtr ptr = Marshal.AllocHGlobal((int)mvarBuffer.Length);
			Marshal.Copy(mvarBuffer, 0, ptr, (int)mvarBuffer.Length);
			int bytesWritten = Internal.Methods.ftdi_write_data(ref _H, ptr, mvarBuffer.Length);

			mvarBuffer = new byte[0];
			return bytesWritten;
		}

		public void Reset()
		{
			Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_usb_reset(ref _H);
			Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}

		public void SetBaudRate(int baudRate)
		{
			Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_set_baudrate(ref _H, baudRate);  // set baud rate
			Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}

		private BitsPerWord _bits = BitsPerWord.Eight;
		private StopBits _stopBits = StopBits.One;
		private Parity _parity = Parity.None;

		public void SetDataCharacteristics(BitsPerWord bits, StopBits stopBits, Parity parity)
		{
			Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_set_line_property(ref _H, bits, stopBits, parity);
			Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}
		public void SetFlowControl(FlowControl control, byte uXon, byte uXoff)
		{
			// Internal.Constants.FT_STATUS status = Internal.Methods.FT_SetFlowControl(mvarHandle, control, uXon, uXoff);
			// Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}
		public void ClearRTS()
		{
			// Internal.Constants.FT_STATUS status = Internal.Methods.FT_ClrRts(mvarHandle);
			// Internal.Methods.ftdi_status_to_exception(status, ref _H);
		}
		public void Purge(PurgeBuffer buffers = PurgeBuffer.Both)
		{
			// Internal.Constants.FT_STATUS status = Internal.Methods.FT_Purge(mvarHandle, buffers);
			// Internal.Methods.ftdi_status_to_exception(status, ref _H);
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
                        Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_set_line_property2(ref _H, _bits, _stopBits, _parity, true);
                        Internal.Methods.ftdi_status_to_exception(status, ref _H);
                        break;
                    }
                    case false:
                    {
                        Internal.Constants.FT_STATUS status = Internal.Methods.ftdi_set_line_property2(ref _H, _bits, _stopBits, _parity, false);
							Internal.Methods.ftdi_status_to_exception(status, ref _H);
							break;
                    }
                }
            }
        }

		/*

		public static int GetDeviceCount()
        {
            int numDevs = 0;
            Internal.Constants.FT_STATUS status = Internal.Methods.FT_ListDevices(ref numDevs, IntPtr.Zero, Internal.Constants.FT_LISTDEVICES.ListNumberOnly);
            Internal.Methods.ftdi_status_to_exception(status, ref _H);
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
        */

		/// <summary>
		/// Closes the handle to this FTD2XX device.
		/// </summary>
		public void Close()
        {
            Internal.Methods.ftdi_usb_close(ref _H);
        }
    }
}
