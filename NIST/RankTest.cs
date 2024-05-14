// ReSharper disable InconsistentNaming
// ReSharper disable SuggestBaseTypeForParameter ParameterTypeCanBeEnumerable.Local
using System;
using System.Collections.Generic;
using BitUtils;
using NIST.MathAdditions;
using NIST.Extensions;

namespace NIST {
	public class RankTest : NISTTest {
		private readonly int M;
		private readonly int Q;
		
		public RankTest(BitArray bitArray, int M, int Q) : base(bitArray) {
			this.M = M;
			this.Q = Q;
		}

		public override double CalcPValue() {
			if (n < Calc_Min_n())
				throw new ArgumentException($"The amount of bits must be at least 38*M*Q = {Calc_Min_n()}, but n is only {n}.");
			int N = Calc_N();
			int m = Calc_m();
			var matrices = CreateMatrices(N);
			var ranks = Calc_Ranks(matrices, m);
			var probabilities = Calc_Probabilities(m);
			double ChiSquared = Calc_ChiSquared(ranks, probabilities, N, m);
			return Calc_PValue(ChiSquared);
		}

		private int Calc_Min_n() => 38 * M * Q;
		
		private int Calc_N() => n / (M * Q);

		private int Calc_m() => Math.Min(M, Q);

		private BinaryMatrix[] CreateMatrices(int N) {
			var matrices = new BinaryMatrix[N];
			for (int i = 0; i < N; i++)
				matrices[i] = new BinaryMatrix(_bitArray, i, M, Q);
			return matrices;
		}
		
		private static int[] Calc_Ranks(BinaryMatrix[] matrices, int m) {
			var ranks = new int[m + 1];
			foreach (var matrix in matrices)
				ranks[BinaryMatrixRankCalculator.CalcRank(matrix)]++;
			return ranks;
		}
		
		private double[] Calc_Probabilities(int m) {
			var probabilities = new List<double>(m + 1);
			for (int r = m; r >= 0; r--) {
				double probability = Math.Pow(2, r * (Q + M - r) - M * Q) * CalcProduct(r);
				if (probability < 0.0055)
					break;
				probabilities.Add(probability);
			}
			
			// The last probability is equal to the remaining probability,
			// which is 1 minus the sum of probabilities from index 0 to the second-to-last index.
			probabilities[probabilities.Count - 1] = 1 - probabilities.SumTo(probabilities.Count - 1);
			return probabilities.ToArray();
		}

		private double CalcProduct(int r) {
			double product = 1;
			for (int i = 0; i < r; i++)
				product *= (1.0 -  Math.Pow(2, i - Q)) * (1.0 -  Math.Pow(2, i - M)) / (1.0 -  Math.Pow(2, i - r));
			return product;
		}
		
		private static double Calc_ChiSquared(int[] ranks, double[] probabilities, int N, int m) {
			int startIndex = m - probabilities.Length + 2;
			double sum = 0;
			for (int r = m; r >= startIndex; r--)
				sum += (ranks[r] - probabilities[m - r] * N).Sqr() / (probabilities[m - r] * N);
			sum += (N - ranks.SumWith(startIndex) - probabilities.LastEl() * N).Sqr() / (probabilities.LastEl() * N);
			return sum;
		}
		
		private static double Calc_PValue(double ChiSquared) => Math.Exp(-ChiSquared / 2);

		public override string ToString() => "Rank Test";
	}
}