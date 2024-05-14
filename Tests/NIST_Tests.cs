// ReSharper disable InconsistentNaming
using System.IO;
using BitUtils;
using BitUtils.Extensions;
using NIST;
using NUnit.Framework;
using Tests.Utils;

namespace Tests {
	[TestFixture]
	public class NIST_Tests {
		
		[Test]
		public void TestFrequency() {
			var bitArray = CreateBitArray("1011010101");
			var frequencyTest = new FrequencyTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(frequencyTest), 0.527089);
			
			bitArray = CreateBitArray("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			frequencyTest = new FrequencyTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(frequencyTest), 0.109599);
		}
		
		[Test]
		public void TestBlockFrequency() {
			var bitArray = CreateBitArray("1011010101");
			var blockFrequency = new BlockFrequencyTest(bitArray, 3);
			AdditionalAssert.AreEqual(CalcPValue(blockFrequency), 0.801252);
			
			bitArray = CreateBitArray("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			blockFrequency = new BlockFrequencyTest(bitArray, 10);
			AdditionalAssert.AreEqual(CalcPValue(blockFrequency), 0.706438);
		}

		[Test]
		public void TestRuns() {
			var bitArray = CreateBitArray("1001101011");
			var runsTest = new RunsTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(runsTest), 0.147232);
			
			bitArray = CreateBitArray("1100100100001111110110101010001000100001011010001100001000110100110001001100011001100010100010111000");
			runsTest = new RunsTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(runsTest), 0.500798);
		}
		
		[Test]
		public void TestLongestRun() {
			var bitArray = CreateBitArray("11001100000101010110110001001100111000000000001001001101010100010001001111010110100000001101011111001100111001101101100010110010");
			var longestRunOfOnesTest = new LongestRunOfOnesTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(longestRunOfOnesTest), 0.180609);
		}
		
		[Test]
		public void TestRank() {
			var bits = string
				.Join("", File.ReadAllLines(@"..\..\data.e"))
				.Replace(" ", "")
				.Substring(0, 100000);
			var bitArray = CreateBitArray(bits);
			var rankTest = new RankTest(bitArray, 32, 32);
			AdditionalAssert.AreEqual(CalcPValue(rankTest), 0.532069);
		}
		
		[Test]
		public void TestDiscreteFourierTransform() {
			var bits = string
				.Join("", File.ReadAllLines(@"..\..\data.e"))
				.Replace(" ", "")
				.Substring(0, 100000);
			var bitArray = CreateBitArray(bits);
			var discreteFourierTransformTest = new DiscreteFourierTransformTest(bitArray);
			AdditionalAssert.AreEqual(CalcPValue(discreteFourierTransformTest), 0.976849);
		}
		
		[Test]
		public void TestLinearComplexity() {
			var bits = string
				.Join("", File.ReadAllLines(@"..\..\data.e"))
				.Replace(" ", "")
				.Substring(0, 1000000);
			var bitArray = CreateBitArray(bits);
			var linearComplexityTest = new LinearComplexityTest(bitArray, 1000);
			AdditionalAssert.AreEqual(CalcPValue(linearComplexityTest), 0.845406);
		}

        [Test]
        public void TestUniversal()
        {
	        var bits = string
		        .Join("", File.ReadAllLines(@"..\..\data.e"))
		        .Replace(" ", "")
		        .Substring(0, 1000000);
	        var bitArray = CreateBitArray(bits);
            var universalTest = new UniversalTest(bitArray);
            AdditionalAssert.AreEqual(CalcPValue(universalTest), 0.282567);
        }

        private static BitArray CreateBitArray(string bits) => new BitArray(bits.ToByteArray(), bits.Length);

		private static double CalcPValue(NISTTest nistTest) {
			return nistTest.CalcPValue();
		}
	}
}