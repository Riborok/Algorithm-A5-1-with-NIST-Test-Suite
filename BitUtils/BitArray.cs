using BitUtils.Extensions;

namespace BitUtils {
	public class BitArray {
		private readonly byte[] _bytes;
		private readonly int _lastByteIndex;
		private readonly int _lastBitIndexInLastByte;

		public int Length { get; }
		
		public BitArray(byte[] bytes) : this(bytes, bytes.Length * Bits.InByte) {
		}
		
		public BitArray(byte[] bytes, int length) {
			_bytes = bytes;
			Length = length;

			_lastBitIndexInLastByte = length % Bits.InByte - 1;
			if (_lastBitIndexInLastByte == -1) 
				_lastBitIndexInLastByte = Bits.LastIndexInByte;
			_lastByteIndex = bytes.Length - 1;
		}

		/// Gets the value of the bit at the specified index in Big Endian order.
		public int this[int bitNum] {
			get {
				var (byteIndex, bitIndex) = GetIndexesForBit(bitNum);
				return _bytes[byteIndex].GetBit(bitIndex);
			}
		}

		private (int byteIndex, int bitIndex) GetIndexesForBit(int bitNum) {
			// Calculate the byte index containing the bit
			int byteIndex = bitNum / Bits.InByte;

			// Calculate the bit index within the byte, accounting for Little Endian
			int lastBitIndex = byteIndex == _lastByteIndex ? _lastBitIndexInLastByte : Bits.LastIndexInByte;
			int bitIndex = lastBitIndex - bitNum % Bits.InByte;

			return (byteIndex, bitIndex);
		}
	}
}