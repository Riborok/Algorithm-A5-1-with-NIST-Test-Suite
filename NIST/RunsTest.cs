// ReSharper disable InconsistentNaming
using System;
using BitUtils;
using MathNet.Numerics;

namespace NIST {
	public class RunsTest : NISTTest {
		public RunsTest(BitArray bitArray) : base(bitArray) {
		}

		public override double CalcPValue() {
			double Pi = Calc_Pi();
			if (Math.Abs(Pi - 0.5) >= 2.0 / Math.Sqrt(n))
				return 0.0;
			int Vobs = Calc_Vobs();
			return Calc_PValue(Vobs, Pi);
		}
		
		private double Calc_Pi() {
			int onesCount = 0;
			for (int j = 0; j < n; j++) 
				onesCount += _bitArray[j];
			return (double)onesCount / n;
		}
		
		private int Calc_Vobs() {
			int Vobs = 1;
			for (int i = 1; i < n; i++) 
				if (_bitArray[i - 1] != _bitArray[i])
					Vobs++;
			return Vobs;
		}

		private double Calc_PValue(int Vobs, double Pi) {
			double dividend = Vobs - 2 * n * Pi * (1 - Pi);
			double divisor = 2 * Math.Sqrt(2 * n) * Pi * (1 - Pi);
			return SpecialFunctions.Erfc(Math.Abs(dividend) / divisor);
		}
		
		public override string ToString() => "Runs Test";
	}
}