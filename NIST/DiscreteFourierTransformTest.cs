// ReSharper disable InconsistentNaming
// ReSharper disable SuggestBaseTypeForParameter ParameterTypeCanBeEnumerable.Local ReturnTypeCanBeEnumerable.Local
using System;
using System.Linq;
using System.Numerics;
using BitUtils;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;

namespace NIST {
	public class DiscreteFourierTransformTest :  NISTTest {
		public DiscreteFourierTransformTest(BitArray bitArray) : base(bitArray) {
		}

		public override double CalcPValue() {
			var X = Calc_X();
			var S = DFT(X);
			var M = Calc_M(S);
			var T = Calc_T();
			var N1 = Calc_N1(M, T);
			var N0 = Calc_N0();
			var d = Calc_d(N1, N0);
			return Calc_PValue(d);
		}

		private int[] Calc_X() {
			var X = new int[n];
			for (int i = 0; i < n; i++) 
				X[i] = _bitArray[i] == 1 ? 1 : -1;
			return X;
		}
		
		private static Complex[] DFT(int[] X) {
			var S = Initialize_S(X);
			Fourier.Forward(S, FourierOptions.NoScaling);
			return S;
		}
		
		private static Complex[] Initialize_S(int[] X) {
			var S = new Complex[X.Length];
			for (int i = 0; i < X.Length; i++)
				S[i] = new Complex(X[i], 0);
			return S;
		}
		
		private double[] Calc_M(Complex[] S) {
			double[] M = new double[n / 2];
			for (int i = 0; i < n / 2; i++)
				M[i] = S[i].Magnitude;
			return M;
		}
		
		private double Calc_T() => Math.Sqrt(Math.Log(1 / 0.05) * n);

		private static int Calc_N1(double[] M, double T) => M.Count(m => m < T);

		private double Calc_N0() => n * 0.95 / 2.0;
		
		private double Calc_d(int N1, double N0) => (N1 - N0) / Math.Sqrt(n * 0.95 * 0.05 / 4);
		
		private static double Calc_PValue(double d) => SpecialFunctions.Erfc(Math.Abs(d) / Math.Sqrt(2));
		
		public override string ToString() => "Discrete Fourier Transform Test";
	}
}