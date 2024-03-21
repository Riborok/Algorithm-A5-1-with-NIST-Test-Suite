// ReSharper disable InconsistentNaming
using Algorithm5A_1.BitUtils;

namespace Algorithm5A_1.NIST {
	public abstract class NISTTest {
		public const double SignificanceLevel = 0.01;
		
		protected readonly BitArray _bitArray;
		protected int n => _bitArray.Length;

		protected NISTTest(BitArray bitArray) => _bitArray = bitArray;
		
		public abstract double CalcPValue();
		
		public abstract override string ToString();
	}
}