using MathNet.Numerics;

namespace NIST.MathAdditions {
	internal static class MathExtensions {
		public static double Sqr(this double x) => x * x;
		
		public static int Calc_MinusOnePow(int n) => n.IsOdd() ? -1 : 1;
	}
}