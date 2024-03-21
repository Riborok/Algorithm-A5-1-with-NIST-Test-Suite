// ReSharper disable InconsistentNaming
using BitUtils;

namespace NIST {
	public abstract class NISTTest {
		public const double SignificanceLevel = 0.01;
		
		protected readonly BitArray _bitArray;
		protected int n => _bitArray.Length;

		protected NISTTest(BitArray bitArray) => _bitArray = bitArray;
		
		public abstract double CalcPValue();
		
		public abstract override string ToString();
	}
}