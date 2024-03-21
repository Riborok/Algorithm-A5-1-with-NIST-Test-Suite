using System;
using System.Text;

namespace Algorithm5A_1.BitUtils.Extensions {
	public static class BytesExtensions {
		public static string ToBinaryString(this byte[] bytes) {
			var sb = new StringBuilder(bytes.Length * Bits.InByte);
			
			foreach (byte b in bytes)
				sb.Append(Convert.ToString(b, 2).PadLeft(Bits.InByte, '0'));
			
			return sb.ToString();
		}
		
		public static byte[] ToByteArray(this string bits) {
			var bytes = new byte[bits.Length / Bits.InByte + (bits.Length % Bits.InByte == 0 ? 0 : 1)];

			for (int i = 0; i < bytes.Length; i++)
				bytes[i] = Convert.ToByte(bits.GetByte(i * Bits.InByte), 2);
			
			return bytes;
		}

		private static string GetByte(this string bits, int startI) {
			return bits.Substring(startI, Math.Min(Bits.InByte, bits.Length - startI));
		}
	}
}