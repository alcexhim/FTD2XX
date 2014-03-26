using System;
namespace FTD2XX.Internal
{
	internal class Structures
	{
		public struct ftdi_context
		{
			/* USB specific */
			/** libusb's usb_devref _Handle */
			IntPtr usb_dev;
			/** usb read timeout */
			int usb_read_timeout;
			/** usb write timeout */
			int usb_write_timeout;

			/* FTDI specific */
			/** FTDI chip type */
			int /*ftdi_chip_type*/ type;
		    /** baudrate */
		    int baudrate;
			/** bitbang mode state */
			byte bitbang_enabled;
			/** pointer to read buffer for ftdi_read_data */
			IntPtr readbuffer;
			/** read buffer offset */
			uint readbuffer_offset;
			/** number of remaining data in internal read buffer */
			uint readbuffer_remaining;
			/** read buffer chunk size */
			uint readbuffer_chunksize;
			/** write buffer chunk size */
			uint writebuffer_chunksize;
			/** maximum packet size. Needed for filtering modem status bytes every n packets. */
			uint max_packet_size;

			/* FTDI FT2232C requirecments */
			/** FT2232C interface number: 0 or 1 */
			int intf;   /* 0 or 1 */
							 /** FT2232C index number: 1 or 2 */
			int index;       /* 1 or 2 */
							 /* Endpoints */
							 /** FT2232C end points: 1 or 2 */
			int in_ep;
			int out_ep;      /* 1 or 2 */

			/** Bitbang mode. 1: (default) Normal bitbang mode, 2: FT2232C SPI bitbang mode */
			byte bitbang_mode;

			/** EEPROM size. Default is 128 bytes for 232BM and 245BM chips */
			int eeprom_size;

			/** String representation of last error */
			IntPtr error_str;

			/** Buffer needed for async communication */
			IntPtr async_usb_buffer;
			/** Number of URB-structures we can buffer */
			uint async_usb_buffer_size;

			/** Defines behavior in case a kernel module is already attached to the device */
			int /*Constants.ftdi_module_detach_mode*/ module_detach_mode;
		}
	}
}
