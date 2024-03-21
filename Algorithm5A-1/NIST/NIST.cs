using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm5A_1.BitUtils;
using Algorithm5A_1.MathAdditions;
using MathNet.Numerics;

// ReSharper disable InconsistentNaming

namespace Algorithm5A_1.NIST {
	public class NIST {
		public const double SignificanceLevel = 0.01;
		
		private readonly BitArray _bitArray;
		private int n => _bitArray.Length;
		
		public NIST(BitArray bitArray) => _bitArray = bitArray;

		public double CalcFrequency_PValue() => SpecialFunctions.Erfc(Calc_Sobs() / Math.Sqrt(2));
		
		private double Calc_Sobs() => Math.Abs(Calc_Sn()) / Math.Sqrt(n);
		
		private int Calc_Sn() {
			int Sn = 0;
			for (int i = 0; i < n; i++) 
				Sn += _bitArray[i] == 1 ? 1 : -1;
			return Sn;
		}

		public double CalcBlockFrequency_PValue(int M) {
			int N = n / M;
			
			var Pis = Calc_Pis(N, M);
			double chiSquared = Calc_ChiSquaredBF(Pis, M);
			return SpecialFunctionsExtensions.Igamc(N / 2.0, chiSquared / 2.0);
		}
		
		private IEnumerable<double> Calc_Pis(int N, int M) {
			double[] Pis = new double[N];
			for (int i = 0; i < N; i++)
				Pis[i] = Calc_Pi(i, M);
			return Pis;
		}

		private double Calc_Pi() => Calc_Pi(0, n);
		
		private double Calc_Pi(int quantityOfPrevBlocks, int M) {
			int onesCount = 0;
			for (int j = 0; j < M; j++) 
				onesCount += _bitArray[quantityOfPrevBlocks * M + j];
			return (double)onesCount / M;
		}
		
		private static double Calc_ChiSquaredBF(IEnumerable<double> pis, int M) {
			return 4 * M * pis.Sum(pi => (pi - 0.5).Sqr());
		}

		public double CalcRuns_PValue() {
			if (CalcFrequency_PValue() < SignificanceLevel)
				return 0.0;
				
			double pi = Calc_Pi();
			double dividend = Calc_Vobs() - 2 * n * pi * (1 - pi);
			double divisor = 2 * Math.Sqrt(2 * n) * pi * (1 - pi);
			return SpecialFunctions.Erfc(Math.Abs(dividend) / divisor);
		}
		
		private int Calc_Vobs() {
			int Vobs = 1;
			for (int i = 1; i < n; i++) 
				if (_bitArray[i - 1] != _bitArray[i])
					Vobs++;
			return Vobs;
		}

		public double CalcLongestRunOfOnes_PValue() {
			if (n < 128)
				throw new ArgumentException("Not enough data to run test.");
			
			var lrtp = LongestRunTestParameters.GetParameters(n);
			int N = n / lrtp.M;
			double chiSquared = Calc_ChiSquaredLR(lrtp, N, Calc_Vs(lrtp, N));
			
			return SpecialFunctionsExtensions.Igamc(lrtp.K / 2.0, chiSquared / 2.0);
		}
		
		private struct LongestRunTestParameters {
			public int initialRun;
			public int K;
			public int M;
			public double[] Pis;
			public static LongestRunTestParameters GetParameters(int length) {
				LongestRunTestParameters parameters = new LongestRunTestParameters();
				if (length < 6272) {
					parameters.initialRun = 1;
					parameters.K = 3;
					parameters.M = 8;
					parameters.Pis = new [] { 0.21484375, 0.3671875, 0.23046875, 0.1875 };
				}
				else if (length < 75000) {
					parameters.initialRun = 4;
					parameters.K = 5;
					parameters.M = 128;
					parameters.Pis = new [] { 0.1174035788, 0.242955959, 0.249363483, 0.17517706, 0.102701071, 0.112398847 };
				}
				else {
					parameters.initialRun = 10;
					parameters.K = 6;
					parameters.M = 10000;
					parameters.Pis = new [] { 0.0882, 0.2092, 0.2483, 0.1933, 0.1208, 0.0675, 0.0727 };
				}
				return parameters;
			}
		}

		private int[] Calc_Vs(in LongestRunTestParameters lrtp, int N) {
			int[] vs = new int[lrtp.K + 1];
			for (int i = 0; i < N; i++) {
				int longestRun = Calc_LongestRun(i, lrtp.M);
				if (longestRun <= lrtp.initialRun)
					vs[0]++;
				else if (longestRun >= lrtp.initialRun + lrtp.K)
					vs[lrtp.K]++;
				else
					vs[longestRun - lrtp.initialRun]++;
			}
			return vs;
		}
		
		private int Calc_LongestRun(int quantityOfPrevBlocks, int M) {
			int currentRun = 0;
			int longestRun = 0;
			for (int j = 0; j < M; j++) {
				if (_bitArray[quantityOfPrevBlocks * M + j] == 1) {
					currentRun++;
					longestRun = Math.Max(longestRun, currentRun);
				}
				else
					currentRun = 0;
			}
			return longestRun;
		}
		
		private static double Calc_ChiSquaredLR(in LongestRunTestParameters lrtp, int N, int[] Vs) {
			double chiSquared = 0;
			for (int i = 0; i < Vs.Length; i++) 
				chiSquared += (Vs[i] - N * lrtp.Pis[i]).Sqr() / (N * lrtp.Pis[i]);
			return chiSquared;
		}

		public double CalcRank_PValue(int M, int Q) {
		    int N = n / (M * Q);
		    
		    int[] ranks = Calc_Ranks(N, M, Q);
		    int FM = ranks.Count(rank => rank == M);
		    int FM1 = ranks.Count(rank => rank == M - 1);

		    double chiSquared = (FM - 0.2888 * N).Sqr() / (0.2888 * N) +
		                        (FM1 - 0.5776 * N).Sqr() / (0.5776 * N) +
		                        (N - FM - FM1 - 0.1336 * N).Sqr() / (0.1336 * N);
		    
		    return Math.Exp(-chiSquared / 2);
		}

		private int[] Calc_Ranks(int N, int M, int Q) {
			int[] ranks = new int[N];
			for (int i = 0; i < N; i++) {
				var binaryMatrix = new BinaryMatrix(_bitArray, i, M, Q);
				ranks[i] = BinaryMatrixRankCalculator.CalcRank(binaryMatrix);
			}
			return ranks;
		}
	}
}