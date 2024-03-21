// ReSharper disable InconsistentNaming
using System;
using System.Collections.Generic;
using System.Linq;
using BitUtils;
using NIST.MathAdditions;

namespace NIST {
	public class RankTest : NISTTest {
		private const int M = 32;
		private const int Q = 32;
		
		public RankTest(BitArray bitArray) : base(bitArray) {
		}

		public override double CalcPValue() {
			int N = Calc_N();
			var ranks = Calc_Ranks(N);
			int FM = Calc_FM(ranks);
			int FM1 = Calc_FM1(ranks);
			double ChiSquared = Calc_ChiSquared(FM, FM1, N);
			return Calc_PValue(ChiSquared);
		}
		
		private int Calc_N() => n / (M * Q);

		private int[] Calc_Ranks(int N) {
			int[] ranks = new int[N];
			for (int i = 0; i < N; i++) {
				var binaryMatrix = new BinaryMatrix(_bitArray, i, M, Q);
				ranks[i] = BinaryMatrixRankCalculator.CalcRank(binaryMatrix);
			}
			return ranks;
		}

		private int Calc_FM(IEnumerable<int> ranks) => ranks.Count(rank => rank == M);
		
		private int Calc_FM1(IEnumerable<int> ranks) => ranks.Count(rank => rank == M - 1);

		private static double Calc_ChiSquared(int FM, int FM1, int N) {
			return (FM - 0.2888 * N).Sqr() / (0.2888 * N) +
			       (FM1 - 0.5776 * N).Sqr() / (0.5776 * N) +
			       (N - FM - FM1 - 0.1336 * N).Sqr() / (0.1336 * N);
		}
		
		private static double Calc_PValue(double ChiSquared) => Math.Exp(-ChiSquared / 2);

		public override string ToString() => "Rank Test";
	}
}