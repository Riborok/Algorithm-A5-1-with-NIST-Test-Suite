using System.IO;
using Algorithm5A_1.BitUtils;
using Algorithm5A_1.BitUtils.Extensions;
using Algorithm5A_1.NIST;
using NUnit.Framework;
using Tests.Utils;

// ReSharper disable InconsistentNaming

namespace Tests {
	[TestFixture]
	public class NIST_Tests {
		
		[Test]
		public void TestFrequency() {
			NIST nist = CreateNIST("1011010101");
			AdditionalAssert.AreEqual(nist.CalcFrequency_PValue(), 0.527089);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.CalcFrequency_PValue(), 0.109599);
		}
		
		[Test]
		public void TestBlockFrequency() {
			NIST nist = CreateNIST("1011010101");
			AdditionalAssert.AreEqual(nist.CalcBlockFrequency_PValue(3), 0.801252);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.CalcBlockFrequency_PValue(10), 0.706438);
		}

		[Test]
		public void TestRuns() {
			NIST nist = CreateNIST("1001101011");
			AdditionalAssert.AreEqual(nist.CalcRuns_PValue(), 0.147232);
			nist = CreateNIST("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			AdditionalAssert.AreEqual(nist.CalcRuns_PValue(), 0.500798);
		}
		
		[Test]
		public void TestLongestRun() {
			NIST nist = CreateNIST("11001100000101010110110001001100111000000000001001001101010100010001001111010110100000001101011111001100111001101101100010110010");
			AdditionalAssert.AreEqual(nist.CalcLongestRunOfOnes_PValue(), 0.180609);
		}
		
		[Test]
		public void TestRank() {
			NIST nist = CreateNIST(
				string
					.Join("", File.ReadAllLines(@"..\..\data.e"))
					.Replace(" ", "")
					.Substring(0, 100000));
			AdditionalAssert.AreEqual(nist.CalcRank_PValue(32, 32), 0.531905);
		}

		private static NIST CreateNIST(string bits) {
			var bitArray = new BitArray(bits.ToByteArray(), bits.Length);
			return new NIST(bitArray);
		}
	}
}