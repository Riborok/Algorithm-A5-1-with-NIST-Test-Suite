using System.Collections.Generic;
using Algorithm5A_1.BitUtils.Extensions;

// ReSharper disable InconsistentNaming

namespace Algorithm5A_1.Algorithm_A5_1 {
	public class LFSR {
		private uint _bits = 0;
		private readonly int _lastIndex;
		private readonly int _syncBitNum;
		private readonly IReadOnlyList<int> _feedbackNums;

		public LFSR(int lastIndex, int syncBitNum, IReadOnlyList<int> feedbackNums) {
			_lastIndex = lastIndex;
			_syncBitNum = syncBitNum;
			_feedbackNums = feedbackNums;
		}

		public void Shift() {
			uint newBit = CalcNewBit();
			_bits = (_bits << 1) | newBit;
		}

		private uint CalcNewBit() {
			uint newBit = 0;
			foreach (var feedbackNum in _feedbackNums)
				newBit ^= _bits.GetBit(feedbackNum);
			return newBit;
		}

		public void Xor(uint bit) => _bits ^= bit;
		
		public uint SyncBit => _bits.GetBit(_syncBitNum);

		public uint OutputBit => _bits.GetBit(_lastIndex);

		public uint this[int index] => _bits.GetBit(index);
		
		public void Reset() => _bits = 0;
	}
}