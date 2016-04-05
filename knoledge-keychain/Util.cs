// Copyright 2012 Mike Caldwell (Casascius)
// This file is part of Bitcoin Address Utility.

// Bitcoin Address Utility is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Bitcoin Address Utility is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Bitcoin Address Utility.  If not, see http://www.gnu.org/licenses/.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;


namespace Casascius.Bitcoin
{
    public class Util
    {        /// <summary>
        /// Converts a hex string to bytes.  Hex chars can optionally be space-delimited, otherwise,
        /// any two contiguous hex chars are considered to be a byte.  If testingForValidHex==true,
        /// then if any invalid characters are found, the function returns null instead of bytes.
        /// </summary>
        public static byte[] HexStringToBytes(string source, bool testingForValidHex = false)
        {
            List<byte> bytes = new List<byte>();
            bool gotFirstChar = false;
            byte accum = 0;

            foreach (char c in source.ToCharArray())
            {
                if (c == ' ' || c == '-' || c == ':')
                {
                    // if we got a space, then accept it as the end if we have 1 character.
                    if (gotFirstChar)
                    {
                        bytes.Add(accum);
                        accum = 0;
                        gotFirstChar = false;
                    }
                }
                else if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f'))
                {
                    // get the character's value
                    byte v = (byte)(c - 0x30);
                    if (c >= 'A' && c <= 'F') v = (byte)(c + 0x0a - 'A');
                    if (c >= 'a' && c <= 'f') v = (byte)(c + 0x0a - 'a');

                    if (gotFirstChar == false)
                    {
                        gotFirstChar = true;
                        accum = v;
                    }
                    else
                    {
                        accum <<= 4;
                        accum += v;
                        bytes.Add(accum);
                        accum = 0;
                        gotFirstChar = false;
                    }
                }
                else
                {
                    if (testingForValidHex) return null;
                }
            }
            if (gotFirstChar) bytes.Add(accum);
            return bytes.ToArray();
        }
    }
}
