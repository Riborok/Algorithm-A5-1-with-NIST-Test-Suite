using System;
using NUnit.Framework;

namespace Tests.Utils {
	internal static class AdditionalAssert {
		private const double Epsilon = 0.000001;

		public static void AreEqual(double a, double b) {
			Assert.IsTrue(Math.Abs(a - b) < Epsilon, $"Expected: {b}\nBut was: {a}\n");
		}
	}
}