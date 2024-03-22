// ReSharper disable InconsistentNaming
// ReSharper disable ParameterTypeCanBeEnumerable.Local
using System.Linq;
using BitUtils;
using NIST.MathAdditions;

namespace NIST {
	public class BlockFrequencyTest : NISTTest {
		private readonly int M;
		
		public BlockFrequencyTest(BitArray bitArray, int M) : base(bitArray) {
			this.M = M;
		}

		public override double CalcPValue() {
			int N = Calc_N();
			var Pis = Calc_Pis(N);
			double ChiSquared = Calc_ChiSquared(Pis);
			return Calc_PValue(N, ChiSquared);
		}

		private int Calc_N() => n / M;
		
		private double[] Calc_Pis(int N) {
			double[] Pis = new double[N];
			for (int i = 0; i < N; i++)
				Pis[i] = Calc_Pi(i);
			return Pis;
		}

		private double Calc_Pi(int quantityOfPrevBlocks) {
			int onesCount = 0;
			for (int j = 0; j < M; j++) 
				onesCount += _bitArray[quantityOfPrevBlocks * M + j];
			return (double)onesCount / M;
		}
		
		private double Calc_ChiSquared(double[] Pis) {
			return 4 * M * Pis.Sum(pi => (pi - 0.5).Sqr());
		}

		private static double Calc_PValue(int N, double ChiSquared) {
			return SpecialFunctionsExtensions.Igamc(N / 2.0, ChiSquared / 2.0);
		}
		
		public override string ToString() => "Block Frequency Test";
	}
}