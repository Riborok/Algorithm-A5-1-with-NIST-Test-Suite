// ReSharper disable InconsistentNaming
using System;
using BitUtils;
using NIST.MathAdditions;

namespace NIST {
	public class LongestRunOfOnesTest : NISTTest {
		private const int Min_n = 128;

		private LongestRunTestParameters lrtp;
		
		public LongestRunOfOnesTest(BitArray bitArray) : base(bitArray) {
		}

		public override double CalcPValue() {
			if (n < Min_n)
				throw new ArgumentException($"The amount of bits must be at least {Min_n}, but n is only {n}.");
			lrtp = new LongestRunTestParameters(n);
			int N = Calc_N();
			var Vs = Calc_Vs(N);
			double ChiSquared = Calc_ChiSquared(N, Vs);
			return Calc_PValue(ChiSquared);
		}
		
		private int Calc_N() => n / lrtp.M;
		
		private int[] Calc_Vs(int N) {
			int[] Vs = new int[lrtp.K + 1];
			for (int i = 0; i < N; i++) {
				int longestRun = Calc_LongestRun(i, lrtp.M);
				if (longestRun <= lrtp.initialRun)
					Vs[0]++;
				else if (longestRun >= lrtp.initialRun + lrtp.K)
					Vs[lrtp.K]++;
				else
					Vs[longestRun - lrtp.initialRun]++;
			}
			return Vs;
		}
		
		private int Calc_LongestRun(int quantityOfPrevBlocks, int M) {
			int currentRun = 0;
			int longestRun = 0;
			for (int j = 0; j < M; j++) {
				if (_bitArray[quantityOfPrevBlocks * M + j] == 1) {
					currentRun++;
					if (currentRun > longestRun)
						longestRun = currentRun;
				}
				else
					currentRun = 0;
			}
			return longestRun;
		}
		
		private double Calc_ChiSquared(int N, int[] Vs) {
			double ChiSquared = 0;
			for (int i = 0; i < Vs.Length; i++) 
				ChiSquared += (Vs[i] - N * lrtp.Pis[i]).Sqr() / (N * lrtp.Pis[i]);
			return ChiSquared;
		}

		private double Calc_PValue(double ChiSquared) {
			return SpecialFunctionsExtensions.Igamc(lrtp.K / 2.0, ChiSquared / 2.0);
		}
		
		public override string ToString() => "Longest Run Of Ones Test";
		
		private readonly struct LongestRunTestParameters {
			internal readonly int initialRun;
			internal readonly int K;
			internal readonly int M;
			internal readonly double[] Pis;
			
			internal LongestRunTestParameters(int n) {
				if (n < 6272) {
					initialRun = 1;
					K = 3;
					M = 8;
					Pis = new [] { 0.21484375, 0.3671875, 0.23046875, 0.1875 };
				}
				else if (n < 75000) {
					initialRun = 4;
					K = 5;
					M = 128;
					Pis = new [] { 0.1174035788, 0.242955959, 0.249363483, 0.17517706, 0.102701071, 0.112398847 };
				}
				else {
					initialRun = 10;
					K = 6;
					M = 10000;
					Pis = new [] { 0.0882, 0.2092, 0.2483, 0.1933, 0.1208, 0.0675, 0.0727 };
				}
			}
		}
	}
}