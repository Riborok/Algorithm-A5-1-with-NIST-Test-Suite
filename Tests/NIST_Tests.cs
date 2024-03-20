using System;
using System.Collections.Generic;
using Algorithm5A_1.Algorithm_A5_1;
using NUnit.Framework;
using Tests.Utils;

// ReSharper disable InconsistentNaming

namespace Tests {
	[TestFixture]
	public class NIST_Tests {
		
		[Test]
		public void TestFrequency() {
			NIST nist = CreateNIST("1011010101");
			AdditionalAssert.AreEqual(nist.FrequencyP_value(), 0.527089);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.FrequencyP_value(), 0.109599);
		}
		
		[Test]
		public void TestBlockFrequency() {
			NIST nist = CreateNIST("1011010101");
			AdditionalAssert.AreEqual(nist.BlockFrequencyP_value(3), 0.801252);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.BlockFrequencyP_value(10), 0.706438);
		}

		[Test]
		public void TestRuns() {
			NIST nist = CreateNIST("1001101011");
			AdditionalAssert.AreEqual(nist.RunsP_value(), 0.147232);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.RunsP_value(), 0.500798);
		}
		
		[Test]
		public void TestLongestRun() {
			NIST nist = CreateNIST("11001100000101010110110001001100111000000000001001001101010100010001001111010110100000001101011111001100111001101101100010110010");
			AdditionalAssert.AreEqual(nist.LongestRunOfOnesP_value(), 0.180609);
		}

		private static NIST CreateNIST(string bits) {
			var bytes = ParseBinaryString(bits);
			return new NIST(bytes, bits.Length);
		}
		
		private static byte[] ParseBinaryString(string bits) {
			var bytes = new List<byte>();

			for (int i = 0; i < bits.Length; i += Bits.InByte) {
				string byteString = bits.Substring(i, Math.Min(Bits.InByte, bits.Length - i));
				bytes.Add(Convert.ToByte(byteString, 2));
			}

			return bytes.ToArray();
		}
	}
}