// ReSharper disable InconsistentNaming
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitUtils;
using NIST;

namespace App.NIST {
	public class NISTTestCalculator {
		private readonly Control _errorMsgControl;
		private readonly object _errorMsgLock = new object();

		public NISTTestCalculator(Control errorMsgControl) => _errorMsgControl = errorMsgControl;

		public double?[] CalcTestResults(byte[] bytes, int blockSz, int matrixM, int matrixQ) {
			var bitArr = new BitArray(bytes);
			var tasks = new[] {
				Task.Run(() => TryGetResult(new FrequencyTest(bitArr))),
				Task.Run(() => TryGetResult(new BlockFrequencyTest(bitArr, blockSz))),
				Task.Run(() => TryGetResult(new RunsTest(bitArr))),
				Task.Run(() => TryGetResult(new LongestRunOfOnesTest(bitArr))),
				Task.Run(() => TryGetResult(new RankTest(bitArr, matrixM, matrixQ))),
				Task.Run(() => TryGetResult(new DiscreteFourierTransformTest(bitArr)))
			};
			Task.WhenAll(tasks).Wait();
			return tasks.Select(t => t.Result).ToArray();
		}

		private double? TryGetResult(NISTTest nistTest) {
			try {
				return nistTest.CalcPValue();
			}
			catch (ArgumentException exception) {
				lock (_errorMsgLock)
					_errorMsgControl.Text += exception.Message + @" ";
				return null;
			}
		}
	}
}