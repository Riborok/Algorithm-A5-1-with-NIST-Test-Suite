// ReSharper disable InconsistentNaming
using System;
using System.Windows.Forms;
using BitUtils;
using NIST;

namespace App.NIST {
	public class NISTTestCalculator {
		private readonly Control _errorMsgControl;

		public NISTTestCalculator(Control errorMsgControl) => _errorMsgControl = errorMsgControl;

		public double?[] CalcTestResults(byte[] bytes, int blockSz, int matrixM, int matrixQ) {
			var bitArr = new BitArray(bytes);
			return new[] {
				TryGetResult(new FrequencyTest(bitArr)),
				TryGetResult(new BlockFrequencyTest(bitArr, blockSz)),
				TryGetResult(new RunsTest(bitArr)),
				TryGetResult(new LongestRunOfOnesTest(bitArr)),
				TryGetResult(new RankTest(bitArr, matrixM, matrixQ)),
				TryGetResult(new DiscreteFourierTransformTest(bitArr))
			};
		}

		private double? TryGetResult(NISTTest nistTest) {
			try {
				return nistTest.CalcPValue();
			}
			catch (ArgumentException exception) {
				_errorMsgControl.Text += exception.Message + @" ";
				return null;
			}
		}
	}
}