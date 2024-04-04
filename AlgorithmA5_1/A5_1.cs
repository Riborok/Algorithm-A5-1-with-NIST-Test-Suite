// ReSharper disable InconsistentNaming
using System;
using BitUtils;
using BitUtils.Extensions;

namespace AlgorithmA5_1 {
	public class A5_1 {
		public LFSR Lfsr1 { get; }
		public LFSR Lfsr2 { get; }
		public LFSR Lfsr3 { get; }

		public A5_1() {
			Lfsr1 = new LFSR(18, 8, new [] { 18, 17, 16, 13 });
			Lfsr2 = new LFSR(21, 10, new [] { 21, 20 });
			Lfsr3 = new LFSR(22, 10, new [] { 22, 21, 20, 7 });
		}
		
		public void InitV1(ulong key) => Init(key, 100, XorAllV1);

		private void XorAllV1(uint bit) {
			Lfsr1.Xor(bit);
			Lfsr2.Xor(bit);
			Lfsr3.Xor(bit);
		}
		
		public void InitV2(ulong key) => Init(key, 223, XorAllV2);

		private void XorAllV2(uint bit) {
			Lfsr1.Xor(Lfsr1[1] ^ Lfsr1[2] ^ bit);
			Lfsr2.Xor(Lfsr2[1] ^ Lfsr2[2] ^ bit);
			Lfsr3.Xor(Lfsr3[1] ^ Lfsr3[2] ^ bit);
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
			Lfsr1.Reset();
			Lfsr2.Reset();
			Lfsr3.Reset();
		}

		private void ShiftAll() {
			Lfsr1.Shift();
			Lfsr2.Shift();
			Lfsr3.Shift();
		}
		
		private void ShiftAllIncludingSyncBit() {
			uint sb1 = Lfsr1.SyncBit;
			uint sb2 = Lfsr2.SyncBit;
			uint sb3 = Lfsr3.SyncBit;
			
			uint f = Calc_F(sb1, sb2, sb3);

			if (sb1 == f)
				Lfsr1.Shift();
			
			if (sb2 == f)
				Lfsr2.Shift();
			
			if (sb3 == f)
				Lfsr3.Shift();
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
				result |= Lfsr1.OutputBit ^ Lfsr2.OutputBit ^ Lfsr3.OutputBit;
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
