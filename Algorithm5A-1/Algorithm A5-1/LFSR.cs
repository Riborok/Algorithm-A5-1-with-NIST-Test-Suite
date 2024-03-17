using System.Collections.Generic;
using Algorithm5A_1.Extensions;
// ReSharper disable InconsistentNaming

namespace Algorithm5A_1.Algorithm_A5_1 
{
	public class LFSR
	{
		private uint _bits = 0;
		private readonly int _length;
		private readonly uint _syncBitMask;
		private readonly uint[] _feedbackMasks;

		public LFSR(int length, int syncBitNum, IReadOnlyList<int> feedbacks)
		{
			_length = length;
			_syncBitMask = 1u << syncBitNum;
			_feedbackMasks = CreateFeedbackMasks(feedbacks);
		}

		private static uint[] CreateFeedbackMasks(IReadOnlyList<int> feedbacks)
		{
			uint[] feedbackMasks = new uint[feedbacks.Count];
			for (int i = 0; i < feedbackMasks.Length; i++)
				feedbackMasks[i] = 1u << (feedbacks[i] - 1);
			return feedbackMasks;
		}

		public void Shift()
		{
			uint newBit = CalculateNewBit();
			_bits = ((_bits << 1) | newBit) & LengthMask;
		}

		private uint CalculateNewBit()
		{
			uint newBit = 0;
			foreach (var feedbackMask in _feedbackMasks)
				newBit ^= ApplyMask(feedbackMask);
			return newBit;
		}

		private uint ApplyMask(uint mask) => (_bits & mask).ToBit();
		
		private uint LengthMask => (1u << _length) - 1;

		public void Xor(uint bit) => _bits ^= bit;
		
		public uint SyncBit => ApplyMask(_syncBitMask);

		public uint OutputBit => ApplyMask(OutputBitMask);
		
		private uint OutputBitMask => 1u << (_length - 1);
		
		public void Reset() => _bits = 0;

		public uint this[int index] => ApplyMask(1u << index);
	}
}