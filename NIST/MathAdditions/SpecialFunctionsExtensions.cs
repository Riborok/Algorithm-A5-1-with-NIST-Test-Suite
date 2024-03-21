using MathNet.Numerics;

namespace NIST.MathAdditions {
	internal static class SpecialFunctionsExtensions {
		public static double Igamc(double a, double x) {
			double gammaUpperIncomplete = SpecialFunctions.GammaUpperIncomplete(a, x);
			double gamma = SpecialFunctions.Gamma(a);
			return gammaUpperIncomplete / gamma;
		}
	}
}