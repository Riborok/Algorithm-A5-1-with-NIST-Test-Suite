// ReSharper disable InconsistentNaming
using System;
using BitUtils;
using MathNet.Numerics;

namespace NIST {
	public class FrequencyTest : NISTTest {
		public FrequencyTest(BitArray bitArray) : base(bitArray) {
		}

		public override double CalcPValue() {
			int Sn = Calc_Sn();
			double Sobs = Calc_Sobs(Sn);
			return Calc_PValue(Sobs);
		}

		private int Calc_Sn() {
			int Sn = 0;
			for (int i = 0; i < n; i++) 
				Sn += _bitArray[i] == 1 ? 1 : -1;
			return Sn;
		}
		
		private double Calc_Sobs(int Sn) => Math.Abs(Sn) / Math.Sqrt(n);
		
		private static double Calc_PValue(double Sobs) => SpecialFunctions.Erfc(Sobs / Math.Sqrt(2));

		public override string ToString() => "Frequency Test";
	}
}