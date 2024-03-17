using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm5A_1.Extensions {
	public static class BytesExtensions {
		public static string ConvertToBinaryString(this IEnumerable<byte> bytes)
		{
			StringBuilder binaryStringBuilder = new StringBuilder();
			foreach (byte b in bytes)
				binaryStringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
			return binaryStringBuilder.ToString();
		}
	}
}