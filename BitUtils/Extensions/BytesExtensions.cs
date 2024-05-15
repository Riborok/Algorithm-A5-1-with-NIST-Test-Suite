using System;
using System.Text;

namespace BitUtils.Extensions {
    public static class BytesExtensions {
        public static byte[] ToByteArray(this string bits) {
            var bytes = new byte[MathUtils.CeilInt(bits.Length, Bits.InByte)];

            for (var i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(bits.GetByte(i * Bits.InByte), 2);
			
            return bytes;
        }

        private static string GetByte(this string bits, int startI) {
            return bits.Substring(startI, Math.Min(Bits.InByte, bits.Length - startI));
        }
		
        public static string ToBinaryString(this byte[] bytes) {
            return ToBinaryString(bytes, bytes.Length * Bits.InByte); 
        }
		
        public static string ToBinaryString(this byte[] bytes, int bitsToDisplay) {
            var sb = new StringBuilder(bitsToDisplay);
            var fullBytesCount = bitsToDisplay / Bits.InByte;
            var remainingBitsCount = bitsToDisplay % Bits.InByte;
            AppendFullBytes(bytes, fullBytesCount, sb);
            AppendRemainingBits(bytes, fullBytesCount, remainingBitsCount, sb);
            return sb.ToString();
        }

        private static void AppendFullBytes(byte[] bytes, int fullBytesCount, StringBuilder sb) {
            for (var i = 0; i < fullBytesCount; i++) {
                var binaryString = ByteToBinaryString(bytes[i]);
                sb.Append(binaryString);
            }
        }

        private static void AppendRemainingBits(byte[] bytes, int lastByteIndex, int remainingBitsCount, StringBuilder sb) {
            if (remainingBitsCount > 0) {
                var binaryString = ByteToBinaryString(bytes[lastByteIndex]);
                sb.Append(binaryString.Substring(Bits.InByte - remainingBitsCount));
            }
        }

        private static string ByteToBinaryString(byte b) {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }
    }
}