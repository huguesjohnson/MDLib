/*
IPSCreator: Utility to create an IPS file
Originally created for Aridia: Phantasy Star III ROM Editor
Copyright (c) 2007-2018 Hugues Johnson

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.huguesjohnson.IPSCreator
{
    class PatchRecord
    {
        /// <summary>
        /// Create a new instance of PatchRecord.
        /// </summary>
        /// <param name="address">The starting address for the patch record.</param>
        public PatchRecord(int address) 
        {
            this.Address=address;
        }

        /// <summary>
        /// The starting address for the patch record.
        /// </summary>
        private int address;

        /// <summary>
        /// The data for the patch record.
        /// </summary>
        private byte[] data;

        /// <summary>
        /// The starting address for the patch record.
        /// </summary>
        public int Address
        {
            get{return(this.address);}
            set{this.address=value;}
        }

        /// <summary>
        /// The data for the patch record.
        /// </summary>
        public byte[] Data
        {
            get{return(this.data);}
            set{this.data=value;}
        }

        /// <summary>
        /// The length of the data for the patch record.
        /// </summary>
        public int Length 
        {
            get{
                if(this.data==null)
                {
                    return(0);
                }
                else
                {
                    return(this.data.Length);
                }
            }
        }
    }
}
