/*
MegaDriveIO: Utilities to read/write a Mega Drive binary ROM image
Originally created for Aridia: Phantasy Star III ROM Editor
Copyright (c) 2007-2018 Hugues Johnson

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;

namespace com.huguesjohnson.MegaDriveIO
{
	/// <summary>
	/// Class used to represent an uncompressed tile.
	/// </summary>
	public class MDTile
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public MDTile(){ }

		/// <summary>
		/// The address (decimal) in the MegaDrive ROM where this data begins.
		/// </summary>
		private int address;	

		/// <summary>
		/// The address (decimal) in the MegaDrive ROM where this data begins.
		/// </summary>
		public int Address
		{
			get
			{
				return(this.address);
			}
			set
			{
				this.address=value;
			}
		}

		/// <summary>
		/// The pixel data for the tile.
		/// </summary>
		private byte[][] pixelData;

		/// <summary>
		/// The pixel data for the tile.
		/// </summary>
		public byte[][] PixelData
		{
			get
			{
				return(this.pixelData);
			}
			set
			{
				this.pixelData=value;
			}
		}
	}
}
