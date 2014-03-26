using System;
using System.Runtime.InteropServices;

namespace FTD2XX.Internal.Linux
{
	internal static class Methods
	{
		private const string LIBRARY_FILENAME = "ftdi";

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_init(ref Internal.Structures.ftdi_context ftdi);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_usb_open(ref Internal.Structures.ftdi_context ftdi, int vendor, int product);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_read_data(ref Internal.Structures.ftdi_context  /*struct ftdi_context*/ ftdi, IntPtr buf, int size);
		[DllImport(LIBRARY_FILENAME)]
		public static extern int ftdi_write_data(ref Internal.Structures.ftdi_context  /*struct ftdi_context*/ ftdi, IntPtr buf, int size);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_usb_close(ref Internal.Structures.ftdi_context ftdi);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_usb_reset(ref Internal.Structures.ftdi_context ftdi);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_set_baudrate(ref Internal.Structures.ftdi_context ftdi, int baudRate);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_set_line_property(ref Internal.Structures.ftdi_context ftdi, BitsPerWord bits, StopBits stopBits, Parity parity);

		[DllImport(LIBRARY_FILENAME)]
		public static extern Constants.FT_STATUS ftdi_set_line_property2(ref Internal.Structures.ftdi_context ftdi, BitsPerWord bits, StopBits stopBits, Parity parity, bool break_on);
	}
}
