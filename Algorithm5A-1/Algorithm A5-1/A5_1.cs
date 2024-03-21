using System;
using Algorithm5A_1.BitUtils;
using Algorithm5A_1.BitUtils.Extensions;

// ReSharper disable InconsistentNaming

namespace Algorithm5A_1.Algorithm_A5_1 {
	public class A5_1 {
		private readonly LFSR _lfsr1 = new LFSR(18, 8, new [] { 18, 17, 16, 13 });
		private readonly LFSR _lfsr2 = new LFSR(21, 10, new [] { 21, 20 });
		private readonly LFSR _lfsr3 = new LFSR(22, 10, new [] { 22, 21, 20, 7 });
		
		public void InitV1(ulong key) => Init(key, 100, XorAllV1);

		private void XorAllV1(uint bit) {
			_lfsr1.Xor(bit);
			_lfsr2.Xor(bit);
			_lfsr3.Xor(bit);
		}
		
		public void InitV2(ulong key) => Init(key, 223, XorAllV2);

		private void XorAllV2(uint bit) {
			_lfsr1.Xor(_lfsr1[1] ^ _lfsr1[2] ^ bit);
			_lfsr2.Xor(_lfsr2[1] ^ _lfsr2[2] ^ bit);
			_lfsr3.Xor(_lfsr3[1] ^ _lfsr3[2] ^ bit);
		}
		
		private void Init(ulong key, int shiftCount, Action<uint> xorDelegate) {
			ResetAll();

			for (int i = 0; i < Bits.InQword; i++) {
				var keyBit = (uint)key.GetBit(i);
				xorDelegate(keyBit);
				ShiftAll();
			}

			for (int i = 0; i < shiftCount; i++)
				ShiftAllIncludingSyncBit();
		}

		private void ResetAll() {
			_lfsr1.Reset();
			_lfsr2.Reset();
			_lfsr3.Reset();
		}

		private void ShiftAll() {
			_lfsr1.Shift();
			_lfsr2.Shift();
			_lfsr3.Shift();
		}
		
		private void ShiftAllIncludingSyncBit() {
			uint sb1 = _lfsr1.SyncBit;
			uint sb2 = _lfsr2.SyncBit;
			uint sb3 = _lfsr3.SyncBit;
			
			uint f = Calc_F(sb1, sb2, sb3);

			if (sb1 == f)
				_lfsr1.Shift();
			
			if (sb2 == f)
				_lfsr2.Shift();
			
			if (sb3 == f)
				_lfsr3.Shift();
		}
		
		/// <code>
		/// x | y | z | x &amp; y | x &amp; z | y &amp; z | F
		/// -------------------------------------
		/// 0 | 0 | 0 |   0   |   0   |   0   | 0
		/// 0 | 0 | 1 |   0   |   0   |   0   | 0
		/// 0 | 1 | 0 |   0   |   0   |   0   | 0
		/// 0 | 1 | 1 |   0   |   0   |   1   | 1
		/// 1 | 0 | 0 |   0   |   0   |   0   | 0
		/// 1 | 0 | 1 |   0   |   1   |   0   | 1
		/// 1 | 1 | 0 |   1   |   0   |   0   | 1
		/// 1 | 1 | 1 |   1   |   1   |   1   | 1
		/// </code>
		private static uint Calc_F(uint x, uint y, uint z) => (x & y) | (x & z) | (y & z);

		public byte GenerateByte() {
			uint result = 0;
			for (int i = 0; i < Bits.InByte; i++) {
				ShiftAllIncludingSyncBit();
				result <<= 1;
				result |= _lfsr1.OutputBit ^ _lfsr2.OutputBit ^ _lfsr3.OutputBit;
			}
			return (byte) result;
		}

		public byte[] GenerateBytes(int length) {
			byte[] result = new byte[length];
			
			for (int i = 0; i < length; i++)
				result[i] = GenerateByte();
			
			return result;
		}
	}
}