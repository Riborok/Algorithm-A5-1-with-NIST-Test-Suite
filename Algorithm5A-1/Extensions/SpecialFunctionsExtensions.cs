using MathNet.Numerics;

namespace Algorithm5A_1.Extensions {
	public static class SpecialFunctionsExtensions {
		public static double Igamc(double a, double x) {
			double gammaUpperIncomplete = SpecialFunctions.GammaUpperIncomplete(a, x);
			double gamma = SpecialFunctions.Gamma(a);
			return gammaUpperIncomplete / gamma;
		}
	}
}