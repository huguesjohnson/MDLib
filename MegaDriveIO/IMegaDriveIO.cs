using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.huguesjohnson.MegaDriveIO
{
    public interface IMegaDriveIO
    {
        /// <summary>
		/// Write a string value to the rom image.
		/// </summary>
		/// <param name="mdString">The value to write.</param>
        void writeString(MDString mdString);

		/// <summary>
		/// Write a string value to the rom image.
		/// </summary>
		/// <param name="mdString">The value to write.</param>
        /// <param name="stringTerminator">The byte to append at the end of the string to represent the end of the string.</param>
        void writeString(MDString mdString,byte stringTerminator);

		/// <summary>
		/// Write an integer value to the binary image.
		/// </summary>
		/// <param name="mdInt">The value to write.</param>
		void writeInt(MDInteger mdInt);

		/// <summary>
		/// Generate the checksum for a binary rom image.
		/// Based off Gens Calculate_Checksum method in rom.c (GPL code - see http://sourceforge.net/projects/gens/)
		/// </summary>
		/// <returns>The new checksum value.</returns>
		int generateChecksum();

        /// <summary>
        /// Reads the checksum currently stored in the ROM. 
        /// </summary>
        /// <returns>The checksum currently stored in the ROM.</returns>
        int readChecksum();

        /// <summary>
        /// Writes the checksum value to the ROM.
        /// </summary>
        /// <param name="newChecksum">The new checksum value to store in the ROM.</param>
        void writeChecksum(int newChecksum);

        /// <summary>
		/// Read a string from the rom image.
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
        /// <param name="length">The maximum length of the string (number of bytes) to read.</param>
		/// <returns>An string representation of the data read.</returns>
        string readString(int offset,int length);

		/// <summary>
		/// Read a string from the rom image.
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
		/// <param name="length">The maximum length of the string (number of bytes) to read.</param>
        /// <param name="stringTerminator">The byte the represents the end of the string.</param>
		/// <returns>An string representation of the data read.</returns>
		string readString(int offset,int length,byte stringTerminator);

        /// <summary>
        /// Reads the header information.
        /// </summary>
        /// <returns>Header information represented as a string</returns>
        string readHeader();

		/// <summary>
		/// Read an integer from the rom image.
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
		/// <param name="length">The length of the integer (number of bytes) to read.</param>
		/// <returns>An integer representation of the data read.</returns>
		int readInteger(int offset,int length);

		/// <summary>
		/// Read raw bytes from the rom image. 
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
		/// <param name="numBytes">The number of bytes to read.</param>
		/// <returns>An array containing the bytes read.</returns>
		byte[] readBytes(int offset,int numBytes);

		/// <summary>
		/// Write raw bytes from the rom image. 
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
		/// <param name="bytes">The bytes to write.</param>
		void writeBytes(int offset,byte[] bytes);

		/// <summary>
		/// Read a tile from the ROM image.
		/// </summary>
		/// <param name="offset">The address to start at.</param>
		/// <param name="xDimension">The xDimension (width) of the tile.</param>
		/// <param name="yDimension">The yDimension (height) of the tile.</param>
		/// <returns></returns>
		MDTile readTile(int offset,int xDimension,int yDimension);

		/// <summary>
		/// Saves a set of tiles to the ROM image.
		/// </summary>
		/// <param name="tiles">The set of tiles to save.</param>
		void writeTiles(MDTile[] tiles);

        /// <summary>
		/// Saves a tile to the ROM image.
		/// </summary>
		/// <param name="tile">The tile to save.</param>
		void writeTile(MDTile tile);

		/// <summary>
		/// Reads palette data from the ROM image.
		/// </summary>
		/// <param name="offset">The address to start at.</param>
		/// <returns>The palette data starting at the specified offset, contains Palette.SIZE entries.</returns>
		Palette readPalette(int offset);

		/// <summary>
		/// Writes palette data to the ROM image.
		/// </summary>
		/// <param name="palette">The palette data to write, expected to contain Palette.SIZE entries.</param>
		/// <param name="offset">The address to start at.</param>
		void writePalette(Palette palette,int offset);

		/// <summary>
		/// Read an integer from the rom image.
		/// </summary>
		/// <param name="offset">The address to start reading at.</param>
		/// <param name="length">The length of the integer (number of bytes) to read.</param>
		/// <param name="byteOrder">The byte order for the integer.</param>
		/// <returns>An integer representation of the data read.</returns>
		int readInteger(int offset,int length,ByteOrder byteOrder);
    }
}
