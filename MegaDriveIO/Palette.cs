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
	/// Class used to represent a 16-color palette.
	/// </summary>
	[Serializable]
	public class Palette
	{
		/// <summary>
		/// The number of entries in the palette.
		/// </summary>
		public const int SIZE=16;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Palette()
		{
			this.Entries=new PaletteEntry[SIZE];
		}
		
		/// <summary>
		/// The individual palette entries.
		/// </summary>
		private PaletteEntry[] entries;

		/// <summary>
		/// The individual palette entries.
		/// </summary>
		public PaletteEntry[] Entries
		{
			get
			{
				return(this.entries);
			}
			set
			{
				if(value.Length!=SIZE)
				{
					throw(new Exception("Array length must be equal to Palette.SIZE ["+SIZE+"], size passed is ["+value.Length+"]."));
				}
				else
				{
					this.entries=value;
				}
			}
		}
	}
}
