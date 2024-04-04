// ReSharper disable InconsistentNaming
using System.Collections.Generic;
using BitUtils.Extensions;

namespace AlgorithmA5_1 {
	public class LFSR {
		private uint _bits = 0;
		private readonly int _lastIndex;
		private readonly int _syncBitNum;
		private readonly IReadOnlyList<int> _feedbackNums;

		internal LFSR(int lastIndex, int syncBitNum, IReadOnlyList<int> feedbackNums) {
			_lastIndex = lastIndex;
			_syncBitNum = syncBitNum;
			_feedbackNums = feedbackNums;
		}

		internal void Shift() {
			uint newBit = CalcNewBit();
			_bits = (_bits << 1) | newBit;
		}

		private uint CalcNewBit() {
			uint newBit = 0;
			foreach (var feedbackNum in _feedbackNums)
				newBit ^= _bits.GetBit(feedbackNum);
			return newBit;
		}

		internal void Xor(uint bit) => _bits ^= bit;
		
		internal uint SyncBit => _bits.GetBit(_syncBitNum);

		internal uint OutputBit => _bits.GetBit(_lastIndex);

		internal uint this[int index] => _bits.GetBit(index);
		
		internal void Reset() => _bits = 0;

		public override string ToString() {
			char[] binary = new char[_lastIndex + 1];
			for (int i = 0; i <= _lastIndex; i++) 
				binary[_lastIndex - i] = _bits.GetBit(i) == 1 ? '1' : '0';
			return new string(binary);
		}
	}
}
